using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    public class CSSLAuthenticationProvider : IAuthenticationProvider
    {
        public CSSLAuthenticationProvider(IConfigurationProvider configurationProvider)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ConfigurationProvider = configurationProvider;
        }

        public IConfigurationProvider ConfigurationProvider { get; private set; }

        public void ApplyConfiguration(Uri endPoint, WebRequestHandler handler)
        {
            try
            {
                CKubernatesConfig configuration = ConfigurationProvider.GetConfiguration();
                CKubernetesSslConnectionSpec spec = CKubernetesSslConnectionSpec.GetFromConfigFile(configuration);

                if (spec.HostName != endPoint.AbsoluteUri.TrimEnd('/'))
                    throw new Exception(string.Format("Configuration not found for {0}", endPoint.AbsoluteUri));

                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ClientCertificates.Add(spec.Certificate);
                handler.ServerCertificateValidationCallback = CertificateValidationCallBack;
   
            }
            catch (Exception ex)
            {
                throw new Exception("Applying configuration failed", ex);
            }
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
