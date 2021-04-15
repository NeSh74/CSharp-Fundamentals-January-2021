using System;

namespace _08_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggestModel = "";
            double biggestVolume = 0;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * (Math.Pow(r, 2)) * h;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = model;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
