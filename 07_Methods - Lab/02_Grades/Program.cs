using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string gradeInWords = PrintGradeInWords(grade);
            Console.WriteLine(gradeInWords);

        }

        private static string PrintGradeInWords(double grade)
        {
            string gradeInWords = "";
            if (grade >= 2 && grade <= 2.99)
            {
                gradeInWords = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                gradeInWords = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                gradeInWords = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                gradeInWords = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeInWords = "Excellent";
            }

            return gradeInWords;
        }
    }
}