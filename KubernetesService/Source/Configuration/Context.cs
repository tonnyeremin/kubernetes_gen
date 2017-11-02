using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CContext
    {
        [YamlMember(Alias = "context")]
        public CContextDetails ContextDetails { get; set; }

        [YamlMember(Alias = "name")]
        public string Name { get; set; }
    }
}
