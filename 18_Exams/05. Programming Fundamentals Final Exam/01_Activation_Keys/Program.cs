using System;

namespace _01_Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] instructions = input.Split(">>>");
                string command = instructions[0];
                if (command.Contains("Contains"))
                {
                    string substring = instructions[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command.Contains("Flip"))
                {
                    string casing = instructions[1];
                    int startIDx = int.Parse(instructions[2]);
                    int endIdx = int.Parse(instructions[3]);
                    string substring = key.Substring(startIDx, endIdx - startIDx);
                    string replacement = substring.ToUpper();
                    if (casing.Contains("Lower"))
                    {
                        replacement = replacement.ToLower();
                    }

                    key = key.Replace(substring, replacement);
                    Console.WriteLine(key);
                }
                else if (command.Contains("Slice"))
                {
                    int startIDx = int.Parse(instructions[1]);
                    int endIdx = int.Parse(instructions[2]);
                    key = key.Remove(startIDx, endIdx - startIDx);
                    Console.WriteLine(key);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
