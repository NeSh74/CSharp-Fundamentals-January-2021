using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            MatchCollection matches = Regex.Matches(places, @"([=|\/])([A-Z][A-Za-z]{2,})\1");

            List<string> list = new List<string>();
            int count = 0;

            foreach (Match match in matches)
            {
                string item = match.Groups[2].Value;
                count += item.Length;
                list.Add(item);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
