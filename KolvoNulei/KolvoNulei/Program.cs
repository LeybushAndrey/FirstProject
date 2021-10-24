using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolvoNulei
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i = 1; i <= N; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if(a == 0)
                {
                    s++;
                }
            }
            Console.WriteLine(s);
        }
    }
}
