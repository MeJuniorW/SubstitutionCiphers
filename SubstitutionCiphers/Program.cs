using System;

namespace SubstitutionCiphers
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice();
        }
        public static void Choice()
        {
            // Console.WriteLine("Do you wish to encrypt or decrypt ( e / d )\nChoice : ");
            // string choice = Console.ReadLine().ToLower();
            // Console.WriteLine("Enter Text: ");
            string text = Console.ReadLine().ToUpper();
            string encryptedText = AlphaToFroNumeric.EncryptAlphaToFroNumeric(text);
            Console.WriteLine(encryptedText);
        }
    }
}
