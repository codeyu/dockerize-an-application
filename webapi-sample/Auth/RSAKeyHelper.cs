using System.Security.Cryptography;

namespace TodoApi.Auth
{
    public class RSAKeyHelper
    {
        public static RSAParameters GenerateKey()
        {
            using (var rsa = RSA.Create())
            {
                return rsa.ExportParameters(true);
            }
        }
    }
}