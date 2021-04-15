using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string item = tokens[1];
                if (command == "Collect")
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] items = item.Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];
                    int idx = journal.IndexOf(oldItem);
                    if (idx >= 0)
                    {
                        journal.Insert(idx + 1, newItem);
                    }

                }
                else if (command == "Renew")
                {
                    int idx = journal.IndexOf(item);
                    if (idx >= 0)
                    {
                        string element = journal[idx];
                        journal.Remove(element);
                        journal.Add(element);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
