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
        public static string EncryptAlphaToFroNumeric(string unencryptedText)
        {
            char[] charsToIgnore = { ',', ' ', '/', ':', ';', '-', '.' };
            char[] alphabet = GetAlphabet();
            string[] encrypted = new string[unencryptedText.Length];
            for (int i = 0; i < unencryptedText.Length; i++)
            {
                if (!charsToIgnore.Contains(unencryptedText[i]))
                {
                    string numericValue = (Array.IndexOf(alphabet, unencryptedText[i]) + 1).ToString();
                    encrypted[i] = numericValue;
                }
                else
                {
                    encrypted[i] = "0";
                }
            }
            string encryptedText = string.Join('-', encrypted);
            return encryptedText;
        }

        public static string DecryptAlphaToFroNumeric(string encryptedText)
        {

            return "";
        }

    }
}
