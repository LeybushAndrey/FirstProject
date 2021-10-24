using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razryad
{
    class Program
    {
        static int raz(int x)
        {
            int c = 0;
            while (x > 0)
            {
                x = x / 10;
                c++;
            }
            return c;
        }
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write(raz(n) * raz(k));
        }
    }
}
