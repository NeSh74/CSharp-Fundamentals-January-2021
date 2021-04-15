using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = parts[0];
                string student = parts[1];

                if (!studentsByCourses.ContainsKey(course))
                {
                    studentsByCourses.Add(course, new List<string>());
                }

                studentsByCourses[course].Add(student);
            }

            Dictionary<string, List<string>> sortedCourses = studentsByCourses
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
