using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepenChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            double b = a;
           for(int i = 1; i < n; i++)
           {
                 b = b * a;
           }
             if(n == 0)
             {
                b = 1;
             }
            Console.WriteLine(b);
        }
    }
}
