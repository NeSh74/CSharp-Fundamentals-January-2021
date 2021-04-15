using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string typeOfpeople = "";

            if (ages >= 0 && ages <= 2)
            {
                typeOfpeople = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                typeOfpeople = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                typeOfpeople = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                typeOfpeople = "adult";
            }
            else if (ages >= 66)
            {
                typeOfpeople = "elder";
            }
            Console.WriteLine(typeOfpeople);
        }
    }
}
