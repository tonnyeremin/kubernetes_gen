using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;
using System.Net;

namespace KubernetesService.Source.Svc
{
    public class OAuthTokenAuthentificationProvider : IAuthenticationProvider
    {
        public OAuthTokenAuthentificationProvider(IConfigurationProvider configurationProvider)
        {
            ConfigurationProvider = configurationProvider;
        }

        public IConfigurationProvider ConfigurationProvider { get; private set; }

        public void ApplyConfiguration(Uri endPoint, WebRequestHandler handler)
        {
            CKubernatesConfig configuration = ConfigurationProvider.GetConfiguration();
            CKubernetesTokenConnectionSpec tokenSpec = CKubernetesTokenConnectionSpec.GetFromConfigFile(configuration);
          
        }
    }
}
