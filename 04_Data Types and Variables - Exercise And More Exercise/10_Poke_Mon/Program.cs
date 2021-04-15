using System;

namespace _10_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int originNum = n;
            int target = 0;
            while (n >= m)
            {
                n -= m;
                target += 1;
                if (n == originNum / 2 && y > 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
