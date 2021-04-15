using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentname = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentname))
                {
                    students.Add(studentname, new List<double>());
                }

                students[studentname].Add(grade);
            }

            Dictionary<string, double> sortedStudents = students
                .Select(s => new KeyValuePair<string, double>(s.Key, s.Value.Average()))
                .Where(s => s.Value >= 4.50)
                .OrderByDescending(s => s.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
