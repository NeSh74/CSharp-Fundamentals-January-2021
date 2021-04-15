using System;

namespace _05_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (char i = (char)start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
