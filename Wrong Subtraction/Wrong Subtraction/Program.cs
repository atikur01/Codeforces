using System;

namespace Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            long k = 0, b = 0, c, d, i, j, n, m, ck = 0;
            var input = Console.ReadLine();
            var inputsp = input.Split(' ');
             n = int.Parse(inputsp[0]);
             k = int.Parse(inputsp[1]);

            for (i = 1; i <= k; i++)
            {
                b = n % 10;
                if (b == 0)
                {
                    n /= 10;
                }
                else
                {
                    n -= 1;
                }
            }

            Console.WriteLine(n);










        }
    }
}
