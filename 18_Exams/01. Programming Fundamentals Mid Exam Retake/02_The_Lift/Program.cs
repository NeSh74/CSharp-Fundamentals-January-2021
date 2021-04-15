using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] < 4)
                {
                    if (4 - lift[i] > people)
                    {
                        lift[i] += people;
                        people = 0;
                    }
                    else
                    {
                        people -= (4 - lift[i]);
                        lift[i] += (4 - lift[i]);
                    }

                }
            }

            if (people == 0 && lift.Sum() < lift.Count * 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0 && lift.Sum() == lift.Count * 4)
            {
                Console.WriteLine($"There isn't enough space! " +
                                  $"{people} people in a queue!");
            }

            Console.WriteLine(string.Join(' ', lift));
        }
    }
}
