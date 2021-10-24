using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensheSled
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
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    c++;
                }
            }
            Console.Write(c);
        }
    }
}
