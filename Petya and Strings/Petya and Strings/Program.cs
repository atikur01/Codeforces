using System;

namespace Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();

            var line1L = line1.ToUpper();
            var line2L = line2.ToUpper();
          

            int myOutput = 0;
            myOutput = string.Compare(line1L, line2L);
            Console.WriteLine(myOutput.ToString());
           

        }
    }
}
