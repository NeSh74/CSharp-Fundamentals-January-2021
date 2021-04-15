using System;
using System.Text.RegularExpressions;

namespace _03_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex datesregex = new Regex(@"\b[0-9]{2}(.)[A-Za-z]{3}\1\d{4}\b");
            MatchCollection dates = Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Za-z]{3})\k<separator>(\d{4})");

            foreach (Match day in dates)
            {
                Console.WriteLine($"Day: {day.Groups["day"]}, Month: {day.Groups["month"]}, Year: {day.Groups[1]}");
            }
        }
    }
}
