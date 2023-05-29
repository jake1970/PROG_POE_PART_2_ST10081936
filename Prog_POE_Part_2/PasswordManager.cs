using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Prog_POE_Part_2
{
    public class PasswordManager
    {
        private const int byte_Size = 64;
        private const int iterations = 10000;


        public bool passwordMatch(string initialPass, string secondPass)
        {
            if (initialPass.Equals(secondPass))
            {
                return true;
            }
            else
            {

                return false;
            }


        }

        public byte[] CreateSalt()
        {

            var saltByte = new byte[byte_Size];
            var saltProvider = new RNGCryptoServiceProvider();
            saltProvider.GetNonZeroBytes(saltByte);
            string newSalt = Convert.ToBase64String(saltByte);
            return saltByte;
        }

        public string CreateHash(string password, byte[] usedSalt)
        {


            var deriveBytes = new Rfc2898DeriveBytes(password, usedSalt, iterations);
            return Convert.ToBase64String(deriveBytes.GetBytes(256));
        }



        public bool VerifyPassword(string attemptedPassword, string existingPassword, string existingSalt)
        {

            var salt = Convert.FromBase64String(existingSalt);
            var deriveBytes = new Rfc2898DeriveBytes(attemptedPassword, salt, iterations);

            return Convert.ToBase64String(deriveBytes.GetBytes(256)) == existingPassword;


        }

    }
}