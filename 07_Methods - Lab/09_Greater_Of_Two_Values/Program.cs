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

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int greater = GetIntGreater(first, second);
                Console.WriteLine(greater);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char greater = GetCharGreater(first, second);
                Console.WriteLine(greater);
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string greater = GetStringGreater(first, second);
                Console.WriteLine(greater);
            }

        }

        private static string GetStringGreater(string first, string second)
        {
            string greater = "";
            if (first.CompareTo(second) >= 0)
            {
                greater = first;
            }
            else
            {
                greater = second;
            }

            return greater;
        }

        private static char GetCharGreater(char first, char second)
        {
            char greater = (char)0x00;
            if (first >= second)
            {
                greater = first;
            }
            else
            {
                greater = second;
            }

            return greater;
        }

        private static int GetIntGreater(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}