using System;
using System.Linq;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            string reversed = new String(s.ToCharArray().Reverse().ToArray());


            var s1 = Console.ReadLine();
         
           
           

            bool str = reversed.Equals(s1);


            if (str)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }









        }
    }
}
