using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItem = new Dictionary<string, int>
            {
                {"shards",0},
                {"fragments",0 },
                {"motes", 0},
            };
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            bool isRunning = true;
            string winnerItem = String.Empty;
            while (isRunning)
            {
                string[] parts = Console.ReadLine().Split();
                for (int i = 0; i < parts.Length; i += 2)
                {
                    int quantity = int.Parse(parts[i]);
                    string item = parts[i + 1].ToLower();

                    if (legendaryItem.ContainsKey(item))
                    {
                        legendaryItem[item] += quantity;
                        if (legendaryItem[item] >= 250)
                        {
                            winnerItem = item;
                            legendaryItem[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            if (winnerItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winnerItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegenderyitem = legendaryItem
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLegenderyitem)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
