using System;

namespace Team
{
    class Team
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for(int i = 0; i < n; i++)
            {
                int flag = 0;
                var line = Console.ReadLine();
                var data = line.Split(' ');
                var one = int.Parse(data[0]);
                var two = int.Parse(data[1]);
                var three = int.Parse(data[2]);

                if (one + two > 1 || one + three > 1 || two + three > 1)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
                sum = sum + flag;
            }
            Console.WriteLine(sum);
        }
    }
}
