using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!HasValidLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (ContainInvalidCharecter(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ContainDigitCount(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainDigitCount(string password, int count)
        {
            int foundDigitCount = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    foundDigitCount += 1;
                    if (foundDigitCount == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private static bool ContainInvalidCharecter(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasValidLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}