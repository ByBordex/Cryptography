using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherProogs
{
    public static class CipherExtensionMethods
    {
        private static char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] alphaLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

        /// <summary>
        /// Convert a given string into Base64 encoding.
        /// </summary>
        /// <param name="text"> ext to be converted.</param>
        /// <returns></returns>
        public static string ToBase64(this string text)
        {
            if (text == null)
                throw new ArgumentException("Invalid arguments");
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Return the value of a given Base64 string.
        /// </summary>
        /// <param name="text">String to ve decoded.</param>
        /// <returns></returns>
        public static string DecodeBase64(this string text)
        {
            if (text == null)
                throw new ArgumentException("Invalid arguments");
            byte[] bytes = Convert.FromBase64String(text);
            return Encoding.ASCII.GetString(bytes);
        }


        /// <summary>
        /// Performs caesar cipher method over a given string.
        /// </summary>
        /// <param name="text">String to be treated.</param>
        /// <param name="shift">Offset applied to te string.</param>
        /// <param name="encrypt">true to encrypt, false to decrypt. True by default.</param>
        /// <returns></returns>
        public static String CaesarCipher(this string text, int shift, bool encrypt = true)
        {
            if (new Object[] { text, shift, encrypt }.Any(x => x == null))
            {
                throw new ArgumentException("Invalid parameters.");
            }

            shift *= encrypt ? 1 : -1;

            var cipherArray = text.ToArray().Select(ch =>
            {
                if (char.IsUpper(ch))
                {
                    ch = alphaUpper[(Array.IndexOf(alphaUpper, ch) + shift + 26) % 26];
                }
                else if (char.IsLower(ch))
                {
                    ch = alphaLower[(Array.IndexOf(alphaLower, ch) + shift + 26) % 26];
                }
                return ch;
            });
            return string.Join("", cipherArray);
        }

        /// <summary>
        /// Performs Vigenere cipher method over a given string.
        /// </summary>
        /// <param name="text"> Text to be treated.</param>
        /// <param name="key"> String to be used as a key.</param>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        public static String VignereCipher(this string text, string key, bool encrypt = true)
        {
            if (new Object[] { text, key, encrypt }.Any(x => x == null) || key.Count() <= 0)
                throw new ArgumentException("Invalida parameters");

            var keyValues = key.ToLower().Select(x => Array.IndexOf(alphaLower, x)).ToList();
            if (!encrypt)
                keyValues = keyValues.Select(x => -x).ToList();
            int keyIndex = 0;

            //For each character, spin around the alphabet arrays to find its new value.
            var cipherArray = text.ToArray().Select(ch =>
            {
                if (char.IsUpper(ch))
                {
                    ch = alphaUpper[(Array.IndexOf(alphaUpper, ch) + keyValues[keyIndex++] + 26) % 26];
                }
                else if (char.IsLower(ch))
                {
                    ch = alphaLower[(Array.IndexOf(alphaLower, ch) + keyValues[keyIndex++] + 26) % 26];
                }

                if (keyIndex >= keyValues.Count())
                    keyIndex = 0;
                return ch;
            });

            return string.Join("", cipherArray);
        }
    }
}
