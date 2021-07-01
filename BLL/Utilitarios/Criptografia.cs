using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Utilitarios
{
    public class Criptografia
    {

        #region -- HashValue --
        public string HashValue(string value)
        {
            var encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            var hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (var b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }
        #endregion

    }
}
