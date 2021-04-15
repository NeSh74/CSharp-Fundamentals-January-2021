using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int min = PrintMin(first, second, third);
            Console.WriteLine(min);
        }

        private static int PrintMin(int first, int second, int third)
        {
            return Math.Min(Math.Min(first, second), third);
        }
    }
}