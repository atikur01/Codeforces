using System;

namespace A._Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = Console.ReadLine();
            var input1split = input1.Split();

            var n = int.Parse(input1split[0]);
            var k = int.Parse(input1split[1]);

            var input2 = Console.ReadLine();
            var input2split = input2.Split(' ');

            int[] score = new int[100];
            int  sum = 0,j;

            for (int i = 0; i < n; i++)
            {
               score[i] = int.Parse(input2split[i]);
            }

            for(j = 0; j< n;j++)
            {


                if (score[j] >= score[k - 1] && score[j] > 0)
                {
                    sum++;
                }



            }

            Console.WriteLine(sum);




















        }
    }
}
