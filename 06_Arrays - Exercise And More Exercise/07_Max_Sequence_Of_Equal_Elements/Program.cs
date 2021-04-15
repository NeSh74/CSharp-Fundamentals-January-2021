using System;
using System.Linq;

namespace _07_Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestSequenceSize = 0;
            int bestsequenceNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int sequenceSize = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNums = numbers[j];
                    if (currentNum == rightNums)
                    {
                        sequenceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = sequenceSize;
                    bestsequenceNum = currentNum;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestsequenceNum} ");
            }

            Console.WriteLine();
        }
    }
}
