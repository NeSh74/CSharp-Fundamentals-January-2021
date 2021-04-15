using System;
using System.Linq;

namespace _03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double average = numbers.Average();
            int[] result = numbers
                .Where(n => n > average)
                .OrderByDescending(n => n)
                .Take(5)
                .ToArray();

            if (result.Length == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
