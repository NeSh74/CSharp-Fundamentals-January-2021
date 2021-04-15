using System;

namespace _01_Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] instructions = input.Split(":|:");
                string command = instructions[0];

                if (command.Contains("InsertSpace"))
                {
                    int idx = int.Parse(instructions[1]);
                    concealedMessage = concealedMessage.Insert(idx, " ");
                }
                else if (command.Contains("Reverse"))
                {
                    string substring = instructions[1];

                    if (concealedMessage.Contains(substring))
                    {
                        concealedMessage =
                            concealedMessage.Remove(concealedMessage.IndexOf(substring), substring.Length);
                        var reverse = new string(substring.Reverse().ToArray());
                        concealedMessage += reverse;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command.Contains("ChangeAll"))
                {
                    string substring = instructions[1];
                    string replacment = instructions[2];
                    concealedMessage = concealedMessage.Replace(substring, replacment);
                }

                Console.WriteLine(concealedMessage);
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
