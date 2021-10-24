using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign
{
    class Program
    {
        static int sign(int x)
        {
            if (x < 0)
            {
                return (-1);
            }
            else
            {
                if(x == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        public static void Main()
        {
            int z = 2;
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[z];
            for (int k = 0; k < z; k++)
            {
                int x = Convert.ToInt32(ss[k]);
                a[k] = x;
            }
            Console.Write(sign(a[0]) + sign(a[1]));
        }
    }
}
