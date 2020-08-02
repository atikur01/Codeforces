using System;

namespace Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var x = int.Parse(Console.ReadLine());

           

            var str = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < x-1; i++)
            {
                if (str[i] == str[i + 1])
                    count++;
            }

            Console.WriteLine(count);


        }
    }
}
