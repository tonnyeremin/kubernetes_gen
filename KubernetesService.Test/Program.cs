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
            using (
                CKubernetesService service =
                    new CKubernetesService(new Uri(@"https:\\kubeclu-kube-782436mgmt.westeurope.cloudapp.azure.com"),
                        new CCurrentUserConfigurartionReader()))
            {
              string version =  service.Instance.GetAPIVersions().ApiVersion;
            }
        }
    }
}
