using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamechatChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 10; a < 100; a++)// интервал от 1 до N
            {
               int s = a % 10;
               int b = a / 10;
                int x = 2 * s * b;
                if (a == x)
                {
                    Console.Write(a + ",");
                    continue;
                }
            }
        }
    }
}
