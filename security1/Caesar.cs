using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security1
{
    internal class Caesar
    {
        public static string Encipher(string plaintext, int key)
        {
            string ciphertext = string.Empty;
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char encryptedChar = (char)((((c + key) - baseChar) % 26) + baseChar);
                    ciphertext += encryptedChar;
                }
                else
                {
                    ciphertext += c;
                }
            }

            return ciphertext;
        }
    }
}
