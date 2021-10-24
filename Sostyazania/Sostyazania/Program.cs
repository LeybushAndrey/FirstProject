using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sostyazania
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 2;
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] y = new int[z];
            for(int k = 0; k < z; k++)
            {
                int x = Convert.ToInt32(ss[k]);
                y[k] = x;
            }
            int n = y[0];
            int m = y[z - 1];
            int c = 0;
            int b = 0;
            int max = 0;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string p = Console.ReadLine();
                string[] pp = p.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(pp[j]);
                    c = c + a[i, j];
                }
                if (c > max)
                {
                    max = c;
                    b = i;
                }
                c = 0;
            }
            Console.WriteLine(max);
            Console.Write(b);
        }
    }
}
