using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmpl = int.Parse(Console.ReadLine());
            int secondtEmpl = int.Parse(Console.ReadLine());
            int thirdEmpl = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            int neededHours = 0;
            int empEff = firstEmpl + secondtEmpl + thirdEmpl;

            while (studentCount > 0)
            {
                neededHours++;
                if (neededHours % 4 == 0)
                {
                    continue;
                }

                studentCount -= empEff;
            }

            Console.WriteLine($"Time needed: {neededHours }h.");
        }
    }
}
