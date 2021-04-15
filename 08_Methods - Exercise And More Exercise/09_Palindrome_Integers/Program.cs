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
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                Console.WriteLine(IsPalindrome(line));
            }
        }

        private static bool IsPalindrome(string character)
        {
            for (int i = 0; i < character.Length / 2; i++)
            {
                if (character[i] != character[character.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }
    }
}