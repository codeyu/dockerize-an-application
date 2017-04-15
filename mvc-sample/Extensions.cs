using System.Text;
using System.Security.Cryptography;
namespace mvc_sample
{
    public static class Extensions
    {
        public static string ToMd5(this string stringToHash)
        {
            var md5 = IncrementalHash.CreateHash(HashAlgorithmName.MD5);
            md5.AppendData(Encoding.UTF8.GetBytes(stringToHash));
            
            var stringBuilder = new StringBuilder();
            var arrByte = md5.GetHashAndReset();
            for (int i = 0; i < arrByte.Length; i++)
            {
                stringBuilder.Append(arrByte[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}