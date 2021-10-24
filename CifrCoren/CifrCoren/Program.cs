using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifrCoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i = 1; i < n; i++)
            {
                while (n > 0)
                {
                    s = s + (n % 10);
                    n = n / 10;
                }
                n = s;
                if (s >= 10)
                {
                    s = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine(s);
                    break;
                }
            }  
        }
    }
}
