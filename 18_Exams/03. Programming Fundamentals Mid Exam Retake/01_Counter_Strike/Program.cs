using System;

namespace _01_Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int win = 0;
            bool isWin = true;


            while (input != "End of battle")
            {
                int distanceOfEnemy = int.Parse(input);

                if (initialEnergy < distanceOfEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {win} won battles and {initialEnergy} energy");

                    isWin = false;
                    break;
                }

                win++;
                initialEnergy -= distanceOfEnemy;
                if (win % 3 == 0)
                {
                    initialEnergy += win;
                }
                input = Console.ReadLine();
            }

            if (isWin)
            {
                Console.WriteLine($"Won battles: {win}. Energy left: {initialEnergy}");
            }
        }
    }
    }
}
