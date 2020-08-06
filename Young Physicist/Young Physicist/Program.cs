using System;

namespace Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int o, n, a, b, c, s, t, u;

            s = 0;

            t = 0;

            u = 0;

            n = int.Parse(Console.ReadLine());

            for (o = 0; o < n; o++)

            {

                var f = Console.ReadLine();
                var g = f.Split();

                a = int.Parse(g[0]);
                b = int.Parse(g[1]);
                c = int.Parse(g[2]);




             

                s = s + a;

                t = t + b;

                u = u + c;

            }

            if (s == 0 && t == 0 && u == 0) Console.WriteLine("YES");

            else Console.WriteLine("NO");









        }
    }
}
