using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split('|').ToList();
            string input = Console.ReadLine();
            while (input != "Yohoho!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Loot")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string loot = tokens[i];
                        if (!loots.Contains(loot))
                        {
                            loots.Insert(0, loot);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < loots.Count)
                    {
                        string item = loots[index];
                        loots.RemoveAt(index);
                        loots.Add(item);
                    }
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(tokens[1]);
                    int index = loots.Count - count;
                    List<string> lastItems = new List<string>();
                    if (loots.Count < count)
                    {
                        for (int i = 0; i < loots.Count; i++)
                        {
                            lastItems.Add(loots[i]);
                        }
                        Console.WriteLine(string.Join(", ", lastItems));
                        loots.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            lastItems.Add(loots[index + i]);
                        }
                        Console.WriteLine(string.Join(", ", lastItems));
                        loots.RemoveRange(index, count);
                    }
                }
                input = Console.ReadLine();
            }
            double sum = 0;
            for (int i = 0; i < loots.Count; i++)
            {
                string item = loots[i];
                int length = loots[i].Length;
                sum += length;
            }
            double average = sum / loots.Count;
            if (loots.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {average:F2} pirate credits.");
            }
        }
    }
}
