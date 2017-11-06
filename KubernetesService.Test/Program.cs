using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KubernetesService.Models;

namespace KubernetesService.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string cluster = "https://kubeclu-kube-782436mgmt.westeurope.cloudapp.azure.com";
            IConfigurationProvider confProvider = new CConfigurartionProviderUserProfile();
            IAuthenticationProvider authProvider = new CSSLAuthenticationProvider(confProvider);
            using (CKubernetesService instance = CKubernetesService.Connect(new Uri(cluster), authProvider))
            {
                var podList = instance.Service.ListCoreV1NamespacedPod("devns");
                foreach(var item in podList.Items)
                {
                    Console.WriteLine(item.Metadata.Name);
                }
                Console.ReadKey();
            }

               
        }
    }
}
