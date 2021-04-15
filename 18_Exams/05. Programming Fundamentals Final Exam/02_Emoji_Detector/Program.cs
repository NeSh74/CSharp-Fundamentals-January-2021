using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"\d";
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            Regex numRegex = new Regex(numberPattern);
            Regex emojiRegex = new Regex(emojiPattern);

            string text = Console.ReadLine();
            long coolTreshold = 1;

            numRegex.Matches(text)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolTreshold *= x);

            MatchCollection matches = emojiRegex.Matches(text);
            int totalEmojis = matches.Count;
            var coolEmojis = matches
                .Select(m => m.Value)
                .Where(e => e
                    .Substring(2, e.Length - 4)
                    .ToCharArray()
                    .Sum(x => (int)x) > coolTreshold)
                .ToList();



            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");
            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
