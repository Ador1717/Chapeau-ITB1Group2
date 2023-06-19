using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PasswordSaltHasher
    {
        public static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        public static string GenerateSaltedHash(string password, string salt)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000);
            byte[] hash = hashGenerator.GetBytes(20); // 20 bytes for SHA1

            return Convert.ToBase64String(hash);
        }
    }
}
 