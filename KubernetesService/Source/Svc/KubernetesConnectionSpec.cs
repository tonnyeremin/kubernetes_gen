using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    public class CKubernetesSslConnectionSpec
    {
        public string HostName { get; private set; }
        public X509Certificate2 Certificate { get; private set; }
        public Boolean SkipTlsVerify { get; private set; }

        public static CKubernetesSslConnectionSpec GetFromConfigFile(CKubernatesConfig configuration)
        {
            List<CKubernetesSslConnectionSpec> specs = new List<CKubernetesSslConnectionSpec>();
          
            if (configuration.Clusters == null)
                throw new Exception("No available clustres in user config file");

            string contextName = configuration.CurrentContext;
            CContext context = configuration.Contexts.FirstOrDefault(c => c.Name == contextName);
            CCluster cluster = configuration.Clusters.FirstOrDefault(c => c.Name == context.ContextDetails.Cluster);
            CUser user = configuration.Users.FirstOrDefault(u => u.Name == context.ContextDetails.User);
            return new CKubernetesSslConnectionSpec(cluster.ClusterEndpoint.Server, user.UserCredentials.GeneratePfx(), cluster.ClusterEndpoint.SkipTlsVerify);

        }

        private CKubernetesSslConnectionSpec(string hostName, X509Certificate2 certificate, bool skipTlsVerify)
        {
            HostName = hostName;
            Certificate = certificate;
            SkipTlsVerify = skipTlsVerify;
        }
    }
}
