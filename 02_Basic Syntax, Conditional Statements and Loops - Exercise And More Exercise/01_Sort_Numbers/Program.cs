using System;

namespace _01_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(first, second), third);
            int min = Math.Min(Math.Min(first, second), third);
            int middle = first + second + third - (max + min);

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
