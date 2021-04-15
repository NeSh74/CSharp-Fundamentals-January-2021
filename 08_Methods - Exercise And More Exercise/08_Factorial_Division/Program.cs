using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = CalculateFacturial(firstNumber);
            double secondFactorial = CalculateFacturial(secondNumber);

            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFacturial(int number)
        {
            double factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}