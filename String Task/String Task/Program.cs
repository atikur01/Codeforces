using System;

namespace String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string lc =  input.ToLower();
            
            
            
            foreach (char c in lc)
            {
                if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u'|| c == 'y')
                {
                    continue;
                }

                Console.Write($".{c}");
                
            }
          


         
        }
    }
}
