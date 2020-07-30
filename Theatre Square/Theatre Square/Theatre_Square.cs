using System;

namespace Theatre_Square
{
    class Theatre_Square
    {
        static void Main(string[] args)
        {
            long m, n, a, i = 0, j = 0;

            var line = Console.ReadLine();
            var data = line.Split(' ');
            n = long.Parse(data[0]);
            m = long.Parse(data[1]);
            a = long.Parse(data[2]);


            if (n % a == 0)
                i = n / a;
            else
                i = (n / a) + 1;

            if (m % a == 0)
                j = m / a;
            else
                j = (m / a) + 1;

            Console.WriteLine(i * j);


        }
    }
}
