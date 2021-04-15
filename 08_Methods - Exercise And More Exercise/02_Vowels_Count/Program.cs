using System;

namespace MethodsLabEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = VowelsCount(input);
            Console.WriteLine(vowelsCount);
        }

        private static int VowelsCount(string input)
        {
            int count = 0;
            input = input.ToLower();
            foreach (char letter in input)
            {
                if (letter == 'a' ||
                    letter == 'e' ||
                    letter == 'i' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'y')
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}