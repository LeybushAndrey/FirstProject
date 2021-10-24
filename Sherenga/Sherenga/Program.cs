using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherenga
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                a[i] = number;
            }
            int k = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            for (int i = 0; i < n - 1; i++)
            {
                c++;
                if (a[0] < k)
                {
                    c = 1;
                }
                else
                {
                    if (a[n - 1] >= k)
                    {
                        c = n + 1;
                    }
                }
                if ((a[i] >= k) && (a[i] != a[i + 1]) && k > a[i + 1])
                {
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (n == 1)
                {
                    if (k > a[0])
                    {
                        c = 1;
                    }
                    else
                    {
                        c = 2;
                    }
                }
            }
            Console.Write(c);
        }
    }
}
