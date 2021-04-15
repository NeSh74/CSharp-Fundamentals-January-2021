using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_Fancy_Barcodes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcodeInput = Console.ReadLine();
                Match match = regex.Match(barcodeInput);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = match.Groups[1].Value;
                StringBuilder group = new StringBuilder();
                for (int j = 0; j < barcode.Length; j++)
                {
                    //if (char.IsDigit(barcode[j]))
                    if (barcode[j] >= 48 && barcode[j] <= 57)
                    {
                        group.Append(barcode[j]);
                    }
                }

                if (string.IsNullOrEmpty(group.ToString()))
                {
                    group.Append("00");
                }
                Console.WriteLine($"Product group: {group}");
            }
        }
    }
}
