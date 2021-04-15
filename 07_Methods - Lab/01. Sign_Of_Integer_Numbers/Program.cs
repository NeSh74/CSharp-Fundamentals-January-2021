using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = PrintResult(number);
            Console.WriteLine(result);
        }

        private static string PrintResult(int number)
        {
            string result = "";

            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            return $"The number {number} is {result}.";
        }
    }
}