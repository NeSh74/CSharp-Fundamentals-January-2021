using System;
using System.Text;

namespace _06_Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char prevSymbol = '\0';

            StringBuilder result = new StringBuilder();

            foreach (var letter in text)
            {
                if (letter != prevSymbol)
                {
                    result.Append(letter);
                }

                prevSymbol = letter;
            }

            Console.WriteLine(result);
        }
    }
}
