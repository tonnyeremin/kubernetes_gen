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

                Iok8sapicorev1Pod pod = new Iok8sapicorev1Pod
                {
                    Kind = "Pod",
                    ApiVersion = "v1",
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = "nginx",
                        NamespaceProperty = "default",
                        Labels = new Dictionary<string, string>() {{"name", "nginx"}}
                    },
                    Spec = new Iok8sapicorev1PodSpec()
                };

                Iok8sapicorev1Container cont = new Iok8sapicorev1Container
                {
                    Name = "nginx",
                    Image = "nginx"
                };

                Iok8sapicorev1ContainerPort port = new Iok8sapicorev1ContainerPort
                {
                    Name = "containerPort",
                    HostPort = 80
                };

                cont.Ports = new List<Iok8sapicorev1ContainerPort> {port};
                cont.Resources = new Iok8sapicorev1ResourceRequirements()
                {
                    Limits = new Dictionary<string, string>
                    {
                        {"memory", "128Mi"},
                        {"cpu", "500m"}
                    }
                };

                pod.Spec.Containers = new List<Iok8sapicorev1Container> {cont};


                instance.Service.CreateCoreV1NamespacedPod(pod, "default");

                var list = instance.Service.ListCoreV1PodForAllNamespaces();
            }
        }
    }
}
