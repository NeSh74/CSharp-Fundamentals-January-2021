﻿using System;
using System.Text;

namespace _02_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            StringBuilder output = new StringBuilder();

            foreach (var input in inputs)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    output.Append(input);
                }
            }

            Console.WriteLine(output);
        }
    }
}
