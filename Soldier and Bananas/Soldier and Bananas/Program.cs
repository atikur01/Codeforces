using System;

namespace Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, w, ans;
            var a = Console.ReadLine();
            
            var b = a.Split(' ');
            w = int.Parse(b[2]);
            k = int.Parse(b[0]);
            n = int.Parse(b[1]);
            w = w * (w + 1) / 2;
            ans = (w * k) - n;
            if (ans <= 0) ans = 0;
            Console.WriteLine(ans);










        }
    }
}
