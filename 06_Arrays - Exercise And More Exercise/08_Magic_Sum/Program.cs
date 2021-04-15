using System;
using System.Linq;

namespace _08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNum = numbers[j];
                    if (currentNum + rightNum == targetSum)
                    {
                        Console.WriteLine($"{currentNum } {rightNum }");
                        break;
                    }
                }
            }
        }
    }
}
