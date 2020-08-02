using System;


namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {

            var str = Console.ReadLine();

            int one = 0, zero = 0,flag=0;

            for(int i = 0;i < str.Length; i++)
            {
                if(str[i]=='1')
                {
                    one++;
                    zero = 0;
                   
                }
                else
                {
                    zero++;
                    one = 0;
                }
                if (one == 7 || zero == 7)
                {
                    flag = 1;
                    break;
                }

            }

            

            if (flag == 1)
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
