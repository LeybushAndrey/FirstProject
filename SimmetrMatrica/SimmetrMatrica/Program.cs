using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimmetrMatrica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(ss[j]);
                }
            }
            int x = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == a[j, i] && i != j)
                    {
                        c++;
                    }
                }
            }
            if (c == (x - n))
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
