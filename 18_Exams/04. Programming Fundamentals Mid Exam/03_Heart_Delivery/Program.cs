using System;
using System.Linq;

namespace _03_Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] house = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int currentIdx = 0;
            int lastPositionIndex = 0;

            while (command != "Love!")
            {
                string[] tokens = command.Split();
                currentIdx += int.Parse(tokens[1]);
                if (currentIdx >= house.Length)
                {
                    currentIdx = 0;
                }

                if (house[currentIdx] == 0)
                {
                    Console.WriteLine($"Place {currentIdx} already had Valentine's day.");
                }
                else
                {
                    house[currentIdx] -= 2;
                    if (house[currentIdx] == 0)
                    {
                        Console.WriteLine($"Place {currentIdx } has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentIdx}.");
            int housesWithoutVD = house
                .Where(h => h > 0)
                .Count();
            if (housesWithoutVD > 0)
            {
                Console.WriteLine($"Cupid has failed {housesWithoutVD} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
