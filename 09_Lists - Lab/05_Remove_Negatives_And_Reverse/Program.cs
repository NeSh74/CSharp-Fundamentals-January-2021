﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Remove_Negatives_And_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= 0)
                .Reverse()
                .ToList();
            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
