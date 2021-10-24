using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisloSochetanii
{
    class Program
    {
        static int fact(int x)
        {
            int factx = 1;
            for (int i = 1; i <= x; i++)
            {
                factx = factx * i;
            }
            return factx;
        }
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int c = n - k;
            Console.Write(fact(n) / (fact(k) * fact(c)));
        }
    }
}
