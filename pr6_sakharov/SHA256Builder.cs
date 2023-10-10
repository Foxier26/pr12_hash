using System.Text;
using System.Security.Cryptography;

namespace pr6_sakharov
{
    internal class SHA256Builder
    {
        public static string ConvertToHash(string text)
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            byte[] hash = sHA256.ComputeHash(bytes);
            StringBuilder SB = new StringBuilder();
            foreach (byte b in hash )
                SB.Append(b.ToString("X2"));
            return SB.ToString();
        }
    }
}
