﻿using System;
using System.Linq;

namespace _06_Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isExists = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }

                int rightSum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isExists = true;
                    break;
                }
            }

            if (!isExists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
