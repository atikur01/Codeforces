using System;

namespace Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long  n;
            int lucky = 0;

            n = long.Parse(Console.ReadLine());

              


            while (n!=0)
            {
                if (n % 10 == 7 || n % 10 == 4)
                    lucky++;

                n = n / 10;
            }

            if (lucky == 7 || lucky == 4) Console.WriteLine("YES");
               
            else Console.WriteLine("NO");
                
        }
    }
}
