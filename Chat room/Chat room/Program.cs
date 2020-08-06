using System;
using System.Threading;

namespace Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            char[] b = a.ToCharArray();

            var c = "hello";
            int i = 1,j=0;
            foreach(char d in b)
            {
                if(c[i-1]==d)
                {
                    j++;
                    if (i == 5) break;
                    i++;
                }
                
            }

            if( j == 5)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            //foreach (char i in b)
            //{
            //    Console.Write(i);
            //}
           


        }
    }
}
