using System;

namespace Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var data = line.Split(' ');

            var M = int.Parse(data[0]);
            var N = int.Parse(data[1]);

            var a = M * N;

            var b = (int)a / 2;

            Console.WriteLine(b);


        }
    }
}
