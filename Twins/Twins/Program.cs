using System;

namespace Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var insp = input.Split(' ');

            int sum = 0,sum2 =0,coin=0;


            int[] c = new int[n];

            for (int i = 0; i < n; i++)
            {
                c[i] = int.Parse(insp[i]);
                sum += c[i];

            }

            sum = sum / 2;

            Array.Sort(c);

            for (int i = n-1; i >= 0; i--)
            {
                sum2 += c[i];
                coin++;
                if (sum2 > sum) 
                    break;
              

            }

            Console.WriteLine(coin);




        }
    }
}
