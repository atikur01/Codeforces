using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());

            if (w == 0 || w == 1 || w == 2)
            {
                Console.WriteLine("NO");
            }

            if (w > 2)
            {
                if (w % 2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
