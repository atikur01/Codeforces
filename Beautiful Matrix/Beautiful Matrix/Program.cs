using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, x = 0;
            for(i=1;i<=5;i++)
            {
                for(j=1; j<=5;j++)
                {
                   x = int.Parse(Console.ReadLine());

                    if(x==1)
                    {
                        Console.WriteLine($"{Math.Abs(i-3)+Math.Abs(j-3)}");
                    }

                }
            }

        }
    }
}
