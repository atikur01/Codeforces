using System;
using System.Security.Authentication;
using System.Threading;

namespace Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            var str = Console.ReadLine();

            var str_Len = str.Length;

            char[] charX = str.ToCharArray();

            Array.Sort(charX);

           for(int i =0;i< str_Len-1;i++)
            {
                if( charX[i] != charX[i+1] )
                {
                    count++;
                }
            }




            if ( count % 2 == 0)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }




        }
    }
}
