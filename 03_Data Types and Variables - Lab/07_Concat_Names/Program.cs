using System;

namespace _07_Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string result = firstName + delimiter + lastName;
            Console.WriteLine(result);
        }
    }
}
