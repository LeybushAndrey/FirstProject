using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtoroimax
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int max2 = 0;
            int max = 0;
            for (int i = 1; i <= 1000; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number > max)
                {
                    max2 = max;
                    max = number;
                }
                else
                {
                    if (number > max2)
                    {
                        max2 = number;
                    }
                }
            }
            Console.WriteLine(max2);
        }
    }
}
