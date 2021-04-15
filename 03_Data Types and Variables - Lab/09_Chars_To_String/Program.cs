using System;

namespace _09_Chars_To_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{a}{b}{c}");
        }
    }
}
