using System;
using System.Linq;

namespace _09_Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int bestSiqunenceSize = 0;
            int bestStartingSeqIndex = 0;
            int bestSiqSum = 0;
            int[] bestSiq = new int[size];
            int bestSample = 1;

            int sample = 0;

            while (true)
            {
                string line = Console.ReadLine();
                sample += 1;
                if (line == "Clone them!")
                {
                    break;
                }

                int[] sequence = line
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int siquenceSum = 0;
                foreach (var number in sequence)
                {
                    siquenceSum += number;
                }

                for (int i = 0; i < sequence.Length; i++)
                {
                    int currentNum = sequence[i];
                    if (currentNum == 0)
                    {
                        continue;
                    }
                    int currentSequenceSize = 1;

                    for (int j = i + 1; j < sequence.Length; j++)
                    {
                        if (currentNum == sequence[j])
                        {
                            currentSequenceSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequenceSize > bestSiqunenceSize)
                    {
                        bestSiqunenceSize = currentSequenceSize;
                        bestStartingSeqIndex = i;
                        bestSiqSum = siquenceSum;
                        bestSiq = sequence;
                        bestSample = sample;
                    }
                    else if (currentSequenceSize == bestSiqunenceSize)
                    {
                        if (i < bestStartingSeqIndex)
                        {
                            bestSiqunenceSize = currentSequenceSize;
                            bestStartingSeqIndex = i;
                            bestSiqSum = siquenceSum;
                            bestSiq = sequence;
                            bestSample = sample;
                        }
                        else if (i == bestStartingSeqIndex && siquenceSum > bestSiqSum)
                        {

                            bestSiqunenceSize = currentSequenceSize;
                            bestStartingSeqIndex = i;
                            bestSiqSum = siquenceSum;
                            bestSiq = sequence;
                            bestSample = sample;
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSiqSum}.");
            Console.WriteLine(string.Join(" ", bestSiq));
        }
    }
}
