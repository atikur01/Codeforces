using System;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 0;
            string[] arr = new string[150];
            int flag,sum=0;
            
            for(int i = 0; i < n;i++)
            {
                flag = 0;
                arr[i] = Console.ReadLine();
                if (arr[i] == "++X" || arr[i] == "X++")
                {
                    sum = sum +1;
                }

                if(arr[i] == "--X" || arr[i] == "X--")
                {
                    sum = sum - 1;
                }

               

            }

            Console.WriteLine(sum);

            


        }
    }
}
