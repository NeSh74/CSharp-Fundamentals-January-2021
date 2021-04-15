using System;
using System.Linq;
using System.Text;

namespace _05_Multiply_Big_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder sb = new StringBuilder();

            if (multiply == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                reminder += multiply * digit;
                if (reminder > 9)
                {
                    int reminderLastDigit = reminder % 10;
                    reminder /= 10;
                    sb.Append(reminderLastDigit.ToString());
                }
                else
                {
                    sb.Append(reminder.ToString());
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                sb.Append(reminder.ToString());
            }


            Console.WriteLine(string.Concat(sb.ToString().Reverse()));
        }
    }
}
