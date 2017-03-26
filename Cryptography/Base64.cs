using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherMethods
{
    public static class Base64
    {

        public static Func<string, string, bool, string> base64 = (text, key, encrypt) =>
        {
            if (new Object[] { text, encrypt }.Any(x => x == null))
                throw new ArgumentException("Invalida parameters");
            if (encrypt)
                return ToBase64(text);
            return DecodeBase64(text);
        };

        public static string ToBase64(string text)
        {
            if (text == null)
                throw new ArgumentException("Invalid arguments");
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }
        public static string DecodeBase64(string text)
        {
            if (text == null)
                throw new ArgumentException("Invalid arguments");
            byte[] bytes = Convert.FromBase64String(text);
            return Encoding.ASCII.GetString(bytes);
        }

    }
}
