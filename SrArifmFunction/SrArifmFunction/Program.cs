using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrArifmFunction
{
    class Program
    {
        static double sr(int x)
        {
            double srx = 0;
            int sumx = 0;
            for(int i = 1; i <= x; i++)
            {
                sumx = sumx + i;
            }
            srx = (double)sumx / (double)x;
            return srx;
        }
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write(sr(n) + sr(k));
        }
    }
}
