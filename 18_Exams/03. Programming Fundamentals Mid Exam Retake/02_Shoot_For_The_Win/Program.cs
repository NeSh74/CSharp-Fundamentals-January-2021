using System;
using System.Linq;

namespace _02_Shoot_For_The_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int count = 0;

            while (input != "End")
            {
                int idx = int.Parse(input);
                if (idx < 0 || idx >= targets.Length || targets[idx] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int shotTarget = targets[idx];
                targets[idx] = -1;
                count++;
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else
                    {
                        targets[i] += shotTarget;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
