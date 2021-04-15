using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = PrintResult(a, comand, b);
            Console.WriteLine(result);
        }

        private static double PrintResult(int a, string comand, int b)
        {
            double result = 0;
            if (comand == "+")
            {
                result = a + b;
            }
            else if (comand == "-")
            {
                result = a - b;
            }
            else if (comand == "*")
            {
                result = a * b;
            }
            else if (comand == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}