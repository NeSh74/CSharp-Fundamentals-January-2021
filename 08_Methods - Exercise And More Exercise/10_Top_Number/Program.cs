using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int number)
        {
            return IsDivisible(number, 8) && IsHoldsOddDigit(number);
        }

        private static bool IsHoldsOddDigit(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        private static bool IsDivisible(int number, int divider)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            return sum % divider == 0;
        }
    }
}