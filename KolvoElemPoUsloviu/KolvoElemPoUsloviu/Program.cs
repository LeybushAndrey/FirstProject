using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolvoElemPoUsloviu
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
            for (int i = 0; i < n; i++)
            {
              if((a[i] % 3 == 0) && (a[i] % 10 == 7))
              {
                    c++;
              }
            }
            for (int i = 0; i < n; i++)
            {
                if ((a[i] % 3 == 0) && (a[i] % 10 == 7))
                {
                    a[i] = c;
                }
                Console.Write(a[i] +" ");
            }
        }
    }
}
