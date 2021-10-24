using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 1000; a++)
            {
                int s = 1;
                for (int i = 2; i <= a / 2 + 1; i++)
                {
                    int b = a;
                    int x = b % i;
                    if (x == 0)
                    {
                       s = s + i;
                       b = b / i;
                    }
                }
                if (s == a)
                {
                    Console.Write(a + ",");
                    continue;
                }
            }
        }
    }
}
