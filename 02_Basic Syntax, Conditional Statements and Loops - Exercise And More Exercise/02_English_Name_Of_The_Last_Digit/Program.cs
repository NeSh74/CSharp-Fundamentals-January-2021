using System;

namespace _02_English_Name_Of_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string outPut = "";
            switch (n % 10)
            {
                case 0:
                    outPut = "zero";
                    break;
                case 1:
                    outPut = "one";
                    break;
                case 2:
                    outPut = "two";
                    break;
                case 3:
                    outPut = "three";
                    break;
                case 4:
                    outPut = "four";
                    break;
                case 5:
                    outPut = "five";
                    break;
                case 6:
                    outPut = "six";
                    break;
                case 7:
                    outPut = "seven";
                    break;
                case 8:
                    outPut = "eight";
                    break;
                case 9:
                    outPut = "nine";
                    break;
            }
            Console.WriteLine(outPut);
        }
    }
}
