using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetIKolvo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(ss[i]);
                a[i] = x;
                if(a[i] % 2 == 0)
                {
                    c++;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write(c);
        }
    }
}
