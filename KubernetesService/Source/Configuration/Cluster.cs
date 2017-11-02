using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CCluster
    {
        [YamlMember(Alias = "cluster")]
        public CClusterEndpoint ClusterEndpoint { get; set; }

        [YamlMember(Alias = "name")]
        public String Name { get; set; }

    }
}
