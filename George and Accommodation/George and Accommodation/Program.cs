using System;
using System.Threading;

namespace George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                string[] asp = input.Split(' ');
                var a = int.Parse(asp[0]);
                var b = int.Parse(asp[1]);

                if(b-a>=2)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
