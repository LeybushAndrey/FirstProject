using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxChisloKratSemi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            for (double i = b; i >= a; i--)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }  
                else
                {
                    c++;
                }
                if(c == (b - a))
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
