using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePatern = "[A-Za-z]+";
            string digitPattern = "\\d";
            Regex nameRegex = new Regex(namePatern);
            Regex digitRegex = new Regex(digitPattern);
            List<string> participants = Regex.Split(Console.ReadLine(), ",\\s+").ToList();
            Dictionary<string, int> participantsDic = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection charCollection = nameRegex.Matches(input);
                //string name = String.Empty;
                //foreach (Match match in charCollection)
                //{
                //    name += match.Value;
                //}
                string name = string.Join("", charCollection);
                if (participants.Contains(name))
                {
                    MatchCollection digitCollection = digitRegex.Matches(input);
                    int distance = 0;
                    foreach (Match match in digitCollection)
                    {
                        int digit = int.Parse(match.Value);
                        distance += digit;
                    }

                    if (!participantsDic.ContainsKey(name))
                    {
                        participantsDic.Add(name, 0);
                    }

                    participantsDic[name] += distance;
                }
                input = Console.ReadLine();
            }

            participantsDic = participantsDic.OrderByDescending(p => p.Value).ToDictionary(x => x.Key, y => y.Value);
            int counter = 1;
            foreach (KeyValuePair<string, int> kvp in participantsDic)
            {
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter++}{text} place: {kvp.Key }");
                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
