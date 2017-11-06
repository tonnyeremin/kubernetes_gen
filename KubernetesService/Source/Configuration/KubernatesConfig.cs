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
            catch (Exception ex)
            {
                throw new Exception(string.Format("Configuration parser error: {0}", ex.Message), ex);
            }


        }
        public Boolean TryGetCurrentContext(out CUser user, out CCluster cluster)
        {
            user = null;
            cluster = null;

            try
            {
                string contextName = CurrentContext;
                CContext context = Contexts.FirstOrDefault(c => c.Name == contextName);
                cluster = Clusters.FirstOrDefault(c => c.Name == context.ContextDetails.Cluster);
                user = Users.FirstOrDefault(u => u.Name == context.ContextDetails.User);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }


}
