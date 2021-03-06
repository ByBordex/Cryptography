﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherMethods
{
    public static class Caesar
    {


        private static char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] alphaLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

        public static Func<string, string, bool, string> caesar = (text, key, encrypt) => CaesarCipher(text, key, encrypt);

        /// <summary>
        /// Performs caesar cipher method over a given string.
        /// </summary>
        /// <param name="text">String to be treated.</param>
        /// <param name="shift">Shift applied to te string.</param>
        /// <param name="encrypt">true to encrypt, false to decrypt. True by default.</param>
        /// <returns></returns>
        public static String CaesarCipher(string text, string shift, bool encrypt = true)
        {
            if (new Object[] { text, shift, encrypt }.Any(x => x == null))
            {
                throw new ArgumentException("Invalid parameters.");
            }
            var offset = 0;
            try
            {
                offset = int.Parse(shift);
            }
            catch (Exception )
            {
                throw new ArgumentException("Caesar input must be a number, not a string.");
            }

            offset *= encrypt ? 1 : -1;

            ////For each character, spin around the alphabet arrays to find its new value.
            var cipherArray = text.ToArray().Select(ch =>
            {
                if (char.IsUpper(ch))
                {
                    ch = alphaUpper[(Array.IndexOf(alphaUpper, ch) + offset + 26) % 26]; 
                }
                else if (char.IsLower(ch))
                {
                    ch = alphaLower[(Array.IndexOf(alphaLower, ch) + offset + 26) % 26];
                }
                return ch;
            });
            return string.Join("", cipherArray);
        }
    }
}
