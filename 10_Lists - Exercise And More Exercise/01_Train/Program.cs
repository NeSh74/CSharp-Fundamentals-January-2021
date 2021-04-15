using System;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                if (parts.Length == 2)
                {
                    int passangers = int.Parse(parts[1]);
                    train.Add(passangers);
                }
                else
                {
                    int passangers = int.Parse(parts[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWaggon = train[i];
                        if (currentWaggon + passangers <= maxCapacity)
                        {
                            train[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
