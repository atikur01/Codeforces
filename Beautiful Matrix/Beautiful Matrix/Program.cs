using System;

namespace Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();

            var asp = a.Split(' ');
            var bsp = b.Split(' ');
            var csp = c.Split(' ');
            var dsp = d.Split(' ');
            var esp = e.Split(' ');

            int[,] arr = new int[100, 100];

            arr[1, 1] = int.Parse(asp[0]);
            arr[1, 2] = int.Parse(asp[1]);
            arr[1, 3] = int.Parse(asp[2]);
            arr[1, 4] = int.Parse(asp[3]);
            arr[1, 5] = int.Parse(asp[4]);

            arr[2, 1] = int.Parse(bsp[0]);
            arr[2, 2] = int.Parse(bsp[1]);
            arr[2, 3] = int.Parse(bsp[2]);
            arr[2, 4] = int.Parse(bsp[3]);
            arr[2, 5] = int.Parse(bsp[4]);

            arr[3, 1] = int.Parse(csp[0]);
            arr[3, 2] = int.Parse(csp[1]);
            arr[3, 3] = int.Parse(csp[2]);
            arr[3, 4] = int.Parse(csp[3]);
            arr[3, 5] = int.Parse(csp[4]);

            arr[4, 1] = int.Parse(dsp[0]);
            arr[4, 2] = int.Parse(dsp[1]);
            arr[4, 3] = int.Parse(dsp[2]);
            arr[4, 4] = int.Parse(dsp[3]);
            arr[4, 5] = int.Parse(dsp[4]);

            arr[5, 1] = int.Parse(esp[0]);
            arr[5, 2] = int.Parse(esp[1]);
            arr[5, 3] = int.Parse(esp[2]);
            arr[5, 4] = int.Parse(esp[3]);
            arr[5, 5] = int.Parse(esp[4]);

            int x,y,z,g,h;

            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= 5; ++j)
                {
                    x = arr[i, j];
                    if (x == 1)
                    {
                        g = Math.Abs(i - 3);
                        h = Math.Abs(j - 3);
                        y = g + h;

                        Console.WriteLine(y);
                        
                    }
                }
            }














        }
    }
}
