using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCiphers
{
    class AlphaToFroNumeric
    {
        
        public static char[] GetAlphabet()
        {
            char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            return alphabet;
        }
        public static string EncryptAlphaToFroNumeric(string text)
        {
            char[] charsToIgnore = { ',', ' ', '/', ':', ';', '-', '.' };
            char[] alphabet = GetAlphabet();
            string[] unencrypted = text.Split(charsToIgnore);
            text = unencrypted.ToString();
            string[] encrypted = new string[text.Length];
            string encryptedText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                string numericValue = (Array.IndexOf(alphabet, text[i]) + 1).ToString();
                encrypted[i] = numericValue;
            }
            encryptedText = string.Join('-', encrypted);
            return encryptedText;
        }

        public static string DecryptAlphaToFroNumeric(string text)
        {
            throw new NotImplementedException();
        }

    }
}
