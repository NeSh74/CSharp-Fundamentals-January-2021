using System;

namespace _01_The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] instructions = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = instructions[0];

                switch (command)
                {
                    case "Move":
                        int letterCount = int.Parse(instructions[1]);
                        string character = encryptedMessage.Substring(0, letterCount);
                        encryptedMessage = encryptedMessage.Substring(letterCount) + character;
                        break;
                    case "Insert":
                        int idx = int.Parse(instructions[1]);
                        string value = instructions[2];
                        encryptedMessage = encryptedMessage.Insert(idx, value);
                        break;
                    case "ChangeAll":
                        string substring = instructions[1];
                        string replacment = instructions[2];
                        encryptedMessage = encryptedMessage.Replace(substring, replacment);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
