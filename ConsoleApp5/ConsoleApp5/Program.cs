using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int y(int x)
        {
            if (x >= -5 && x <= 5)
                return x;
            else
            {
                if(x < -5)
                {
                    x = 2 * Math.Abs(x) - 1;
                    return x;
                }
                else
                {
                    x = x * 2;
                    return x;
                }
            }
        }
        public static void Main()
        {
            int c = 0;
            for (int i = -25; i <= 15; i++)
            {
                c = c + y(i);
            }
            Console.Write(c);
        }
    }
}
