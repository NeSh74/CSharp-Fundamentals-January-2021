using System;
using System.Text.RegularExpressions;

namespace _02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection output = Regex.Matches(Console.ReadLine(), @"\+359([ -])2\1\d{3}\1\d{4}\b");
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
