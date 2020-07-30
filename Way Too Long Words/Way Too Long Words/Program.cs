using System;

namespace Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                var str = Console.ReadLine();

                var str_length = str.Length;

                if (str_length > 10)
                {
                    Console.WriteLine($"{str[0]}{str_length - 2}{str[str_length - 1]}");
                }
                else
                {
                    Console.WriteLine(str);
                }

            }
            

        }
    }
}
