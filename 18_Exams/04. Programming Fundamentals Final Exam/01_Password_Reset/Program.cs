using System;
using System.Text;

namespace _01_Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] instructions = input.Split();
                string command = instructions[0];

                if (command.Contains("TakeOdd"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        sb.Append(password[i]);
                    }

                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command.Contains("Cut"))
                {
                    int idx = int.Parse(instructions[1]);
                    int lenght = int.Parse(instructions[2]);
                    password = password.Remove(idx, lenght);
                    Console.WriteLine(password);
                }
                else if (command.Contains("Substitute"))
                {
                    string substring = instructions[1];
                    string substitute = instructions[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
