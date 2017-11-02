using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CContextDetails
    {
        [YamlMember(Alias = "cluster")]
        public String Cluster { get; set; }

        [YamlMember(Alias = "user")]
        public String User { get; set; }

        [YamlMember(Alias = "namespace")]
        public String Namespace { get; set; }
    }
}
