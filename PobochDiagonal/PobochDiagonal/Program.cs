using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobochDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(j == m - 1 - i)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if(j < m - 1 - i)
                        {
                            a[i, j] = 0;
                        }
                        else
                        {
                            a[i, j] = 2;
                        }
                    }
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
