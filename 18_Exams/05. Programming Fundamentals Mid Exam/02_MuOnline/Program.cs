using System;

namespace _02_MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonsRooms = Console.ReadLine()
                .Split("|");

            int initialHealth = 100;
            int initialBitcoins = 0;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                string[] room = dungeonsRooms[i].Split();
                string command = room[0];
                int number = int.Parse(room[1]);

                if (command == "potion")
                {
                    int value = 0;
                    if (number + initialHealth <= 100)
                    {
                        value = number;
                    }
                    else
                    {
                        value = 100 - initialHealth;
                    }

                    initialHealth += value;
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    initialBitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins }");
                Console.WriteLine($"Health: {initialHealth }");
            }
        }
    }
}
