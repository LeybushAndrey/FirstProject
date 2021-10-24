using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepenChislaFunction
{
    class Program
    {
        static double pow(double x, double y)
        {
            double z = Math.Pow(x, y);
            return z;
        }
        public static void Main()
        {
            int i = 2;
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            double[] a = new double[i];
            for (int k = 0; k < i; k++)
            {
                double c = Convert.ToDouble(ss[k]);
                a[k] = c;
            }
            Console.Write(pow(a[0], a[1]));
        }
    }
}
