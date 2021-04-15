using System;

namespace _02_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            int result = WordMultiplier(words[0], words[1]);

            Console.WriteLine(result);
        }

        private static int WordMultiplier(string first, string second)
        {
            int minLenght = Math.Min(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                sum += SumRemainingCaharachters(first, minLenght);
            }
            else if (second.Length > first.Length)
            {
                sum += SumRemainingCaharachters(second, minLenght);
            }

            return sum;
        }

        private static int SumRemainingCaharachters(string word, int idx)
        {
            int sum = 0;
            for (int i = idx; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}
