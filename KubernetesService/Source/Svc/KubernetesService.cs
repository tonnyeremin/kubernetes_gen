using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace KubernetesService
{
    public class CKubernetesService :  IDisposable
    {
        private readonly IKubernetes _serviceImpl;
        private readonly WebRequestHandler _handler;

        public CKubernetesService(CKubernetesSslConnectionSpec sslConnectionSpec)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            _handler = new WebRequestHandler();
            _handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            _handler.ClientCertificates.Add(sslConnectionSpec.Certificate);
            _handler.ServerCertificateValidationCallback = CertificateValidationCallBack;
            _serviceImpl = new Kubernetes(new Uri(sslConnectionSpec.HostName), _handler);
            ServiceClient<Kubernetes> svc = _serviceImpl as ServiceClient<Kubernetes>;
        }

        public static CKubernetesService Connect()
        {
            return null;
        }

        public IKubernetes Instance
        {
            get { return _serviceImpl; }
        }
        
        public void Dispose()
        {
            _serviceImpl.Dispose();
            _handler.Dispose();
        }

        private bool CertificateValidationCallBack(
                     object sender,
                     X509Certificate certificate,
                     X509Chain chain,
                     SslPolicyErrors sslPolicyErrors)
        {

            return true;
        }
    }

}
