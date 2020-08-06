using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {

            var str = Console.ReadLine();
            var spl = str.Split(' ');
            
            var Limak = int.Parse(spl[0]);
            var Bob = int.Parse(spl[1]);
            int i;
           for(i = 1; ; i++)
            {
                Limak = Limak * 3;
                Bob = Bob * 2;
                if(Limak > Bob)
                {
                    break;
                }
            }

            Console.WriteLine(i);

        }
    }
}
