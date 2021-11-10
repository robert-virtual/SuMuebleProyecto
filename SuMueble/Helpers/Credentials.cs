using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SuMueble.Helpers
{
    public class Credentials
    {
         public static string Encrypt(string password)
        {
            var saltBytes = new Byte[64];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashedPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            return $"{salt}:{hashedPassword}";
        }
        public static bool Verify(string password, string encryptedPassword)
        {
            var saltAndPassword = encryptedPassword.Split(":");
            var saltBytes = Convert.FromBase64String(saltAndPassword[0]);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);

            return saltAndPassword[1] == Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
        }
    }
}
