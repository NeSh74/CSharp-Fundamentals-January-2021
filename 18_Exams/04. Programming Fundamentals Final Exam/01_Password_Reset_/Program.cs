using System;

namespace _01_Password_Reset_
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] cmpArg = input.Split();
                string command = cmpArg[0];

                if (command == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }

                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(cmpArg[1]);
                    int lenght = int.Parse(cmpArg[2]);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = cmpArg[1];
                    string substitute = cmpArg[2];
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
