using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int a;
            int min = 1000000;
            int s = 1;
            for (int i = N; i >= 1; i--)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < min)
                {
                    s = 1;
                    min = a;
                }

                else
                {
                    if (a == min)
                    {
                        s++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
