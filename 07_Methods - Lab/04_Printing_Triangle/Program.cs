using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimention = int.Parse(Console.ReadLine());
            for (int i = 1; i <= dimention; i++)
            {
                PrintNumbers(i);
            }

            for (int i = dimention - 1; i >= 0; i--)
            {
                PrintNumbers(i);
            }
        }

        private static void PrintNumbers(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}