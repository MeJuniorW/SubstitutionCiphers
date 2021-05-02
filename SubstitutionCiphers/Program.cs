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
            string choice = string.Empty;
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you wish to encrypt or decrypt ( e / d )\nChoice : ");
                    choice = Console.ReadLine().ToLower();
                    if ((choice == "e") || (choice == "encrypt"))
                    {
                        choice = "e";
                    }
                    else if ((choice == "d") || (choice == "decrypt"))
                    {
                        choice = "d";
                    }
                    else
                    {
                        throw new Exception(message: $"{choice} is not a valid choice.");
                    }
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
            }

            Console.WriteLine("Enter Text: ");
            string text = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "e":
                    string encrypted = AlphaToFroNumeric.EncryptAlphaToFroNumeric(text);
                    Console.WriteLine(encrypted);
                    break;

                case "d":
                    string decrypted = AlphaToFroNumeric.DecryptAlphaToFroNumeric(text);
                    Console.WriteLine(decrypted);
                    break;

                default:
                    Console.WriteLine("Exiting");
                    break;
            }
        }
    }
}
