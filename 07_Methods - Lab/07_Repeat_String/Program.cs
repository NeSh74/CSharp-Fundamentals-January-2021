using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string output = PrintOutput(input, n);
            Console.WriteLine(output);

        }

        private static string PrintOutput(string input, int n)
        {
            StringBuilder output = new StringBuilder();
            for (int j = 0; j < n; j++)
            {
                output.Append(input);
            }

            return output.ToString();
        }
    }
}