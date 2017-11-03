using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    public class CSSLAuthenticationProvider : IAuthenticationProvider
    {
        public IConfigurationProvider ConfigurationProvider { get; private set; }

        public void ApplyConfiguration(WebRequestHandler handler)
        {
            CKubernatesConfig configuration = ConfigurationProvider.GetConfiguration();
            CKubernetesSslConnectionSpec spec = CKubernetesSslConnectionSpec.GetFromConfigFile(configuration);
        }
    }
}
