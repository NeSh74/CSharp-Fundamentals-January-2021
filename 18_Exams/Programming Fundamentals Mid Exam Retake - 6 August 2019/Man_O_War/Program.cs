using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] a = command.Split(' ').ToArray();
                if (a[0] == "Fire")
                {
                    int index = int.Parse(a[1]);

                    int fire = int.Parse(a[2]);
                    if (index >= 0 && index < warShip.Count)
                    {

                        warShip[index] -= fire;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                if (a[0] == "Defend")
                {
                    int startIndex = int.Parse(a[1]);
                    int endIndex = int.Parse(a[2]);
                    int dmg = int.Parse(a[3]);
                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count && dmg >= 0)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int n = i;
                            pirateShip[n] -= dmg;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if (a[0] == "Repair")
                {
                    int healIndex = int.Parse(a[1]);
                    int heal = int.Parse(a[2]);
                    if (healIndex >= 0 && healIndex < pirateShip.Count && heal >= 0)
                    {

                        pirateShip[healIndex] += heal;

                        if (pirateShip[healIndex] > maxHealth)
                        {
                            pirateShip[healIndex] = maxHealth;
                        }

                    }

                }
                if (a[0] == "Status")
                {
                    int broken = 0;
                    double lowH = maxHealth - (maxHealth * 0.8);
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (lowH > pirateShip[i])
                        {
                            broken++;
                        }

                    }
                    Console.WriteLine($"{broken} sections need repair.");

                }
            }
            int pirateResult = 0;
            int warResult = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                pirateResult += pirateShip[i];
            }

            Console.WriteLine($"Pirate ship status: {pirateResult}");
            for (int i = 0; i < warShip.Count; i++)
            {
                warResult += warShip[i];

            }

            Console.WriteLine($"Warship status: {warResult}");
        }
    }
}
