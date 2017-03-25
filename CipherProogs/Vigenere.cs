using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherMethods
{
    public static class Vigenere
    {
        private static char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] alphaLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

        /// <summary>
        /// Performs Vigenere cipher method over a given string.
        /// </summary>
        /// <param name="text"> Text to be treated.</param>
        /// <param name="key"> String to be used as a key.</param>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        public static String VignereCipher(string text, string key, bool encrypt = true)
        {
            if (new Object[] { text, key, encrypt }.Any(x => x == null) || key.Count() <= 0)
                throw new ArgumentException("Invalida parameters");

            var keyValues = key.ToLower().Select( x => Array.IndexOf(alphaLower, x) ).ToList();
            if (!encrypt)
                keyValues = keyValues.Select(x => - x).ToList();
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
