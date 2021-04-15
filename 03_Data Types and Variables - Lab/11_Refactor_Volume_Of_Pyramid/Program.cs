using System;

namespace _11_Refactor_Volume_Of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double c = double.Parse(Console.ReadLine());
            double volume = (a * b * c) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
