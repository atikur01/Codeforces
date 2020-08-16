using System;
using System.Dynamic;

namespace Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            int Anton = 0, Danik=0;
            for (int i = 0; i < n; i++)
            {
                if(ch[i]=='A')
                {
                    Anton++;
                }

                else if(ch[i]=='D')
                {
                    Danik++;
                }
            }

            if(Anton>Danik)
            {
                Console.WriteLine("Anton");
            }
            else if(Anton<Danik)
            {
                Console.WriteLine("Danik");
            }
            else if(Anton==Danik)
            {
                Console.WriteLine("Friendship");
            }



        }
    }
}
