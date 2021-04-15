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
            string input = Console.ReadLine();
            string middle = GetMidlleCharacter(input);
            Console.WriteLine(middle);
        }

        private static string GetMidlleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                return $"{input[input.Length / 2 - 1]}{input[input.Length / 2]}";
            }
            return $"{input[(input.Length - 1) / 2]}";
        }
    }
}