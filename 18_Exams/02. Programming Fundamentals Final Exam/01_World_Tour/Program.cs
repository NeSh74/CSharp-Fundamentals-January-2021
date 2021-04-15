using System;

namespace _01_World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] instructions = input.Split(':');
                string command = instructions[0];

                if (command.Contains("Add Stop"))
                {
                    int idx = int.Parse(instructions[1]);
                    string stringValue = instructions[2];

                    if (idx >= 0 && idx < stop.Length)
                    {
                        stop = stop.Insert(idx, stringValue);
                    }
                    Console.WriteLine(stop);
                }
                else if (command.Contains("Remove Stop"))
                {
                    int startIdx = int.Parse(instructions[1]);
                    int endIdx = int.Parse(instructions[2]);
                    if (startIdx >= 0 && startIdx < stop.Length && endIdx >= 0 && endIdx < stop.Length)
                    {
                        int count = endIdx - startIdx + 1;
                        stop = stop.Remove(startIdx, count);
                    }
                    Console.WriteLine(stop);
                }
                else if (command.Contains("Switch"))
                {
                    string oldString = instructions[1];
                    string newString = instructions[2];
                    if (stop.Contains(oldString))
                    {
                        stop = stop.Replace(oldString, newString);
                    }
                    Console.WriteLine(stop);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stop}");
        }
    }
}
