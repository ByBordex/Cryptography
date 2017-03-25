using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCipher
{
    public class Cipher
    {
        public static List<Func<String, String>> cipherMethods = new List<Func<String, String>>();

        public char[] alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private char[] alphaLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

        public static void AddCipherMethod(Func<String, String> f)
        {
            if (f == null)
                return;
            cipherMethods.Add(f);
        }


        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + shift);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public Func<string, int,string> caesar = (text, shift) => { char[] buffer = text.ToLower().ToCharArray();
                                            var cipherArray = buffer.Select(  letter => { if (letter > '<' || letter < 'a') return letter;
                                                                                          letter = (char)(letter + shift);
                                                                                          if(letter > 'z') letter = (char)(letter - 26);
                                                                                          else if (letter < 'a') letter = (char)(letter + 26);
                                                                                          return letter;
                                                                                                    } );
                                            return string.Join("", cipherArray);
        };

        public String caesarCipher(string text, int shift)
        {
            char[] buffer = text.ToArray();

            var cipherArray = buffer.Select(ch =>
                {
                    if (char.IsUpper(ch))
                    {
                        ch = alphaUpper[ (Array.IndexOf(alphaUpper, ch) + shift) % 26 ];
                    }
                    else if (char.IsLower(ch))
                    {
                        ch = alphaLower[(Array.IndexOf(alphaLower, ch) + shift) % 26];
                    }
                    return ch;
                });
            return string.Join("",cipherArray);
        }

    }
}
