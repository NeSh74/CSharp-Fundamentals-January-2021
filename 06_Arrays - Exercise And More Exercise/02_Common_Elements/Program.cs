using System;

namespace _02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firtsInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            foreach (var secondElemnt in secondInput)
            {
                foreach (var firstElemnt in firtsInput)
                {
                    if (firstElemnt == secondElemnt)
                    {
                        Console.Write($"{firstElemnt} ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
