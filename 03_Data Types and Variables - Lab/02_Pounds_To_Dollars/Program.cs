using System;

namespace _02_Pounds_To_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dolar = pound * (decimal)1.31;

            Console.WriteLine($"{dolar:f3}");
        }
    }
}
