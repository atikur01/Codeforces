using System;

namespace Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var str = Console.ReadLine();
            char[] charArr = str.ToCharArray();
            char f = Char.ToUpper(charArr[0]);

            Console.Write(f);

            for(int i = 1; i <= str.Length -1; i++)
            {
                Console.Write(charArr[i]);
            }

            


        }
    }
}
