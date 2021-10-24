using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxsummacifr
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int a = 1; a <= N; a++)
            {
                int b = a;
                int c = s;
                while (b > 0)
                {
                    s = s + b % 10;
                    b = b / 10;
                }
                Console.WriteLine(Math.Max((double)c, s));
            }
        }
    }
}
