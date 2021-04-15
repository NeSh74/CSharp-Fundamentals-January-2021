using System;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());
            double result = PrintResult(number, powerNum);
            Console.WriteLine(result);


        }

        private static double PrintResult(double number, double powerNum)
        {
            return Math.Pow(number, powerNum);
        }
    }
}