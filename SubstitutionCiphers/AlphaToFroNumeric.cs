using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCiphers
{
    class AlphaToFroNumeric
    {
        
        public static Dictionary<char, int> GetEncryptionChartIntValues()
        {
            char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            Dictionary<char, int> A1Z26refChart = new Dictionary<char, int>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                A1Z26refChart.Add(alphabet[i], i + 1);
            }
            return A1Z26refChart;
        }
        public static Dictionary<int, char> GetEncryptionChartCharValues()
        {
            char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            Dictionary<int, char> A1Z26refChart = new Dictionary<int, char>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                A1Z26refChart.Add(i + 1, alphabet[i]);
            }
            return A1Z26refChart;
        }
        public static string EncryptAlphaToFroNumeric(string unencryptedText)
        {
            char[] charsToIgnore = { ',', ' ', '/', ':', ';', '-', '.', '"', '[', ']', '{', '}', '=', '_', '(', ')', '*', '&', '^', '%', '$', '#', '@', '!', '`', '~' };
            Dictionary<char, int> encryptionChart = GetEncryptionChartIntValues();
            string[] encrypted = new string[unencryptedText.Length];
            for (int i = 0; i < unencryptedText.Length; i++)
            {
                if (encryptionChart.TryGetValue(unencryptedText[i], out int value))
                {
                    encrypted[i] = value.ToString();
                }
                else
                {
                    encrypted[i] = "0";
                }
            }
            return string.Join('-', encrypted);
        }

        public static string DecryptAlphaToFroNumeric(string encryptedText)
        {
            char[] seperators = { ',', ' ', '/', ':', ';', '-', '.', '"', '[', ']', '{', '}', '=', '_', '(', ')', '*', '&', '^', '%', '$', '#', '@', '!', '`', '~' };
            string[] encryptionValues = encryptedText.Split(seperators);
            string decryptedText = string.Empty;
            Dictionary<int, char> encryptionChart = GetEncryptionChartCharValues();
            for (int i = 0; i < encryptionValues.Length; i++)
            {
                _ = Int32.TryParse(encryptionValues[i], out int key);
                key = ((key > 26) || (key < 0)) ? 0 : key;
                if (encryptionChart.TryGetValue(key, out char value))
                {
                    decryptedText += value;
                }
                else
                {
                    decryptedText += ' ';
                }
            }
            return decryptedText;
        }

    }
}
