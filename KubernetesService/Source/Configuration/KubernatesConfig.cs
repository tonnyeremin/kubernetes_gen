using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CKubernatesConfig
    {
        [YamlMember(Alias = "preferences")]
        public IDictionary<string, object> Preferences { get; set; }

        [YamlMember(Alias = "apiVersion")]
        public String ApiVersion { get; set; }

        [YamlMember(Alias = "kind")]
        public String Kind { get; set; }

        [YamlMember(Alias = "current-context")]
        public String CurrentContext { get; set; }

        [YamlMember(Alias = "contexts")]
        public IEnumerable<CContext> Contexts { get; set; }

        [YamlMember(Alias = "clusters")]
        public IEnumerable<CCluster> Clusters { get; set; }

        [YamlMember(Alias = "users")]
        public IEnumerable<CUser> Users { get; set; }

        public static CKubernatesConfig Desirialize(string congfigStr)
        {
            try
            {
                Deserializer yamlDesrializer = new Deserializer();
                CKubernatesConfig config = yamlDesrializer.Deserialize<CKubernatesConfig>(congfigStr);
                return config;
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Configuration parser error: {0}", ex.Message), ex);
            }


        }
    }


}
