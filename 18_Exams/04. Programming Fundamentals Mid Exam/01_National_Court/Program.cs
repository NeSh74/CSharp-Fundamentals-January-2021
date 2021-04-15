using System;

namespace _01_National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            int studentHour = 0;
            int nededHours = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            while (studentCount > 0)
            {
                studentHour++;
                if (studentHour % 4 == 0)
                {
                    continue;
                }

                studentCount -= nededHours;
            }

            Console.WriteLine($"Time needed: {studentHour }h.");
        }
    }
}
