using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "<Put cluster url here>";
               
            IConfigurationProvider configurartionProvider = new CConfigurartionProviderUserProfile();
            IAuthenticationProvider authenticationProvider = new CSSLAuthenticationProvider(configurartionProvider);

            using (var service = CKubernetesService.Connect(new Uri(uri), authenticationProvider))
            {
                
                Console.WriteLine(service.Version);
            }

            Console.ReadLine();
        }
    }
}
