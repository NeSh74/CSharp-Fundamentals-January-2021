using System;
using System.Linq;

namespace _02_Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                int idx1 = 0;
                int idx2 = 0;
                switch (tokens[0])
                {
                    case "swap":
                        idx1 = int.Parse(tokens[1]);
                        idx2 = int.Parse(tokens[2]);
                        int tempNum = numbers[idx1];
                        numbers[idx1] = numbers[idx2];
                        numbers[idx2] = tempNum;
                        break;
                    case "multiply":
                        idx1 = int.Parse(tokens[1]);
                        idx2 = int.Parse(tokens[2]);
                        numbers[idx1] *= numbers[idx2];
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
