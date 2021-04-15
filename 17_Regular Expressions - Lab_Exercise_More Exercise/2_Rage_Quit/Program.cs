using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string digitPatern = @"\d+";
            string nonDigitPatern = @"\D+";

            MatchCollection digitMatches = Regex.Matches(input, digitPatern);
            MatchCollection stringMatches = Regex.Matches(input, nonDigitPatern);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < digitMatches.Count; i++)
            {
                string element = stringMatches[i].ToString(); ;
                int num = int.Parse(digitMatches[i].ToString());

                for (int j = 0; j < num; j++)
                {
                    result.Append(element);
                }
            }

            int unique = result
                .ToString()
                .Distinct()
                .ToArray().Length;

            Console.WriteLine($"Unique symbols used: {unique}");
            Console.WriteLine(result);
        }
    }
}
