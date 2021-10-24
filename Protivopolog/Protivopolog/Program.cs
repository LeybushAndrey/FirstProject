using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protivopolog
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
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (a[i] + a[j] == 0 && i != j)
                    {
                        Console.Write(i + " " + j);
                    }
                }
            }
        }
    }
}
