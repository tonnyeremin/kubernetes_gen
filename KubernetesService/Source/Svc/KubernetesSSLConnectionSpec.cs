using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    internal class CKubernetesSslConnectionSpec
    {
        public string HostName { get; private set; }
        public X509Certificate2 Certificate { get; private set; }
        public Boolean SkipTlsVerify { get; private set; }

        public static CKubernetesSslConnectionSpec GetFromConfigFile(CKubernatesConfig configuration)
        {
            if (configuration.Clusters == null)
                throw new Exception("No available clustres in user config file");
            CCluster cluster;
            CUser user;
            if (configuration.TryGetCurrentContext(out user, out cluster))
            {
                return new CKubernetesSslConnectionSpec(cluster.ClusterEndpoint.Server, user.UserCredentials.GeneratePfx(), cluster.ClusterEndpoint.SkipTlsVerify);
            }

            throw new Exception("Configuration not found");

        }

        private CKubernetesSslConnectionSpec(string hostName, X509Certificate2 certificate, bool skipTlsVerify)
        {
            HostName = hostName;
            Certificate = certificate;
            SkipTlsVerify = skipTlsVerify;
        }
    }
}
