
using System;
using System.Text;

namespace DigitalBookStore.Common
{
    public static class CommonMethods
    {
        public static string key = "adef@@kfxcbx@";
        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            password += key;
            var bytePassword = Encoding.UTF8.GetBytes(password);

            return Convert.ToBase64String(bytePassword);
        }

        public static string DecryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) 
                return "";
            var decryptedPassword = Convert.FromBase64String(password);
            var result = Encoding.UTF8.GetString(decryptedPassword);
            result = result.Substring(0, Math.Abs(result.Length - key.Length));

            return result;
        }
    }
}
