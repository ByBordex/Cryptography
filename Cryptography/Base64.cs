using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherMethods
{
    public static class Base64
    {

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
