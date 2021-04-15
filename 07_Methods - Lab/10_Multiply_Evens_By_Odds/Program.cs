using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetEvenSum(number);
            int oddSum = GetOddSum(number);
            Console.WriteLine(evenSum * oddSum);
        }

        private static int GetEvenSum(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            return oddSum;
        }

        private static int GetOddSum(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            return oddSum;
        }
    }
}