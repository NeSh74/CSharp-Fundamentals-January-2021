using System;
using System.Text;

namespace _04_Caesar_Cipher_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedVersion = new StringBuilder();
            foreach (var letter in text)
            {
                char encryptedLetter = (char)(letter + 3);
                encryptedVersion.Append(encryptedLetter);
            }

            Console.WriteLine(encryptedVersion);
        }
    }
}
