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
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = Sum(firstNumber, secondNumber);
            int diff = Substract(sum, thirdNumber);

            Console.WriteLine(diff);
        }

        private static int Substract(int first, int second)
        {
            return first - second;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}