using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
        private readonly CKubernatesConfig _config;
        private readonly HttpClientHandler _handler;

        public CKubernetesService(Uri baseUri, IConfigurationReader reader)
        {
  
            _config = reader.Read();
            _handler = new HttpClientHandler();

            _serviceImpl = new Kubernetes(baseUri, _handler);
          
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
