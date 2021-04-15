using System;
using System.Linq;

namespace _04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var threeBest = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", threeBest));
        }
    }
}
