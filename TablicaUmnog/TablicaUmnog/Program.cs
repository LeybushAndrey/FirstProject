using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaUmnog
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 2;
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[z];
            for(int k = 0; k < z; k++)
            {
                int x = Convert.ToInt32(ss[k]);
                a[k] = x;
            }
            int n = a[0];
            int m = a[z-1];
            int[,] b = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    b[i, j] = (i + 1) * (j + 1);
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
