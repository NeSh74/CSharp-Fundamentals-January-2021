using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arr = input.Split();

                string command = arr[0];
                int index = int.Parse(arr[1]);
                int value = int.Parse(arr[2]);

                switch (command)
                {
                    case "Shoot":

                        if (index < targets.Count && index > -1)
                        {
                            targets[index] -= value;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;
                    case "Add":

                        if (index < targets.Count && index > -1)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":

                        int startIndex = index - value;
                        int endIndex = index + value;

                        if (startIndex >= 0 && endIndex < targets.Count)
                        {
                            targets.RemoveRange(startIndex, 2 * value + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;

                }
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
