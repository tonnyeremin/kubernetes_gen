using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
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


        public X509Certificate2 GeneratePfx()
        {
            byte[] keyData = null;
            byte[] certData = null;

            if (!string.IsNullOrWhiteSpace(ClientKeyData))
            {
                keyData = Convert.FromBase64String(ClientKeyData);
            }


            if (keyData == null)
            {
                throw new Exception("certData is empty");
            }

            if (!string.IsNullOrWhiteSpace(ClientCertificateData))
            {
                certData = Convert.FromBase64String(ClientCertificateData);
            }


            if (certData == null)
            {
                throw new Exception("certData is empty");
            }

            var cert = new X509CertificateParser().ReadCertificate(new MemoryStream(certData));

            object obj;
            using (var reader = new StreamReader(new MemoryStream(keyData)))
            {
                obj = new PemReader(reader).ReadObject();
                var key = obj as AsymmetricCipherKeyPair;
                if (key != null)
                {
                    var cipherKey = key;
                    obj = cipherKey.Private;
                }
            }

            var rsaKeyParams = (RsaPrivateCrtKeyParameters)obj;

            var store = new Pkcs12StoreBuilder().Build();
            store.SetKeyEntry("K8SKEY", new AsymmetricKeyEntry(rsaKeyParams), new[] { new X509CertificateEntry(cert) });

            using (var pkcs = new MemoryStream())
            {
                store.Save(pkcs, new char[0], new SecureRandom());
                return new X509Certificate2(pkcs.ToArray());
            }
        }

    }
}
