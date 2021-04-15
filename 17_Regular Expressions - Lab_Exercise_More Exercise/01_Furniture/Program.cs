using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");

            string input = null;
            List<string> furnitures = new List<string>();
            double totalPrice = 0;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                double quantity = double.Parse(match.Groups["quantity"].Value);
                furnitures.Add(name);
                totalPrice += quantity * price;
            }

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
