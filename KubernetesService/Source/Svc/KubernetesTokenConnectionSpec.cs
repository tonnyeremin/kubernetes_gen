using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;
namespace KubernetesService
{
    internal class CKubernetesTokenConnectionSpec
    {
        public String Server { get; private set; }
        public TokenCredentials Token { get; private set; }

        public CKubernetesTokenConnectionSpec(string server, string token)
        {
            Server = server;
            Token = new TokenCredentials(token);
        }

        public static CKubernetesTokenConnectionSpec GetFromConfigFile(CKubernatesConfig configuration)
        {
            if (configuration.Clusters == null)
                throw new Exception("No available clustres in user config file");
            CCluster cluster;
            CUser user;
            if (configuration.TryGetCurrentContext(out user, out cluster))
            {
                return new CKubernetesTokenConnectionSpec(cluster.ClusterEndpoint.Server, user.UserCredentials.Token);
            }

            throw new Exception("Configuration not found");

        }
    }
}
