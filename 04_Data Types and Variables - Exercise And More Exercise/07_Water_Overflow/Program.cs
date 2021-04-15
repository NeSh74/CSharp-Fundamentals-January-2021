using System;

namespace _07_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int quantityWaterToPour = int.Parse(Console.ReadLine());
                if (quantityWaterToPour + sum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += quantityWaterToPour;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
