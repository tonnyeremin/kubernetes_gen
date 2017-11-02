using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace KubernetesService
{
    public class CClusterEndpoint
    {
        [YamlMember(Alias = "certificate-authority")]
        public String CertificateAuthority { get; set; }

        [YamlMember(Alias = "certificate-authority-data")]
        public String CertificateAuthorityData { get; set; }

        [YamlMember(Alias = "server")]
        public String Server { get; set; }

        [YamlMember(Alias = "insecure-skip-tls-verify")]
        public Boolean SkipTlsVerify { get; set; }
    }
}
