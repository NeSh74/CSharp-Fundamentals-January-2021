using System;
using System.Linq;

namespace _03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstLine = new int[n];
            int[] secondLine = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] output = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int first = output[0];
                int second = output[1];
                if (i % 2 != 0)
                {
                    firstLine[i] = second;
                    secondLine[i] = first;
                }
                else
                {
                    firstLine[i] = first;
                    secondLine[i] = second;
                }
            }

            Console.WriteLine(string.Join(" ", firstLine));
            Console.WriteLine(string.Join(" ", secondLine));
        }
    }
}
