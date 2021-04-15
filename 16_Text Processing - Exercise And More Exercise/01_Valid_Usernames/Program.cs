using System;
using System.Linq;

namespace _01_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ");


            string[] sorted = line.Where(x => x.Length > 3 && x.Length < 16)
                .Where(x => x.All(x => char.IsLetterOrDigit(x) || x.Equals('_') || x.Equals('-'))).ToArray();

            Console.WriteLine(string.Join("\n", sorted));
        }
    }
}
