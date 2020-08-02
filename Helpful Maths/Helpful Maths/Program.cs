using System;

namespace Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            char[] charX = input.ToCharArray();

            Array.Sort(charX);

            
            for(int i =0;i<= charX.Length-1;i++)
            {
               
                if (charX[i] == '+')
                {
                    continue;
                }
                else if (charX[i] != '+')
                {
                    Console.Write($"{charX[i]}");
                    if(i < charX.Length - 1)
                    {
                        Console.Write('+');
                    }
                }
                
            }
            

            

          

        }
    }
}
