using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEasy
{
    class Program
    {
        static void easy(int n)
        {
            int c = 0;
            if (n == 2)
            {
                Console.Write("prime");
            }
                else
                {
                     for (int i = 2; i < n; i++)
                     {
                         if (n % i == 0)
                         {
                              c++;
                         }
                     }
                if (c > 0)
                    Console.Write("composite");
                else
                    Console.Write("prime");
            }   
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            easy(n);
        }
    }
}
