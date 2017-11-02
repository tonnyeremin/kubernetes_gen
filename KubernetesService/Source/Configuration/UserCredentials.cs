using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CUserCredentials
    {
        [YamlMember(Alias = "client-certificate-data")]
        public String ClientCertificateData { get; set; }

        [YamlMember(Alias = "client-certificate")]
        public String ClientCertificate { get; set; }

        [YamlMember(Alias = "client-key-data")]
        public String ClientKeyData { get; set; }

        [YamlMember(Alias = "client-key")]
        public String ClientKey { get; set; }

        [YamlMember(Alias = "token")]
        public String Token { get; set; }

        [YamlMember(Alias = "username")]
        public String UserName { get; set; }

        [YamlMember(Alias = "password")]
        public String Password { get; set; }

        [YamlMember(Alias = "auth-provider")]
        public Dictionary<string, dynamic> AuthProvider { get; set; }
    }
}
