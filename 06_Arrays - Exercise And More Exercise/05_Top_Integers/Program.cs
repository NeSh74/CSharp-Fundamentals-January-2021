using System;
using System.Linq;

namespace _05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                bool isTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNum = numbers[j];
                    if (rightNum >= current)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write($"{current} ");
                }
            }

            Console.WriteLine();
        }
    }
}
