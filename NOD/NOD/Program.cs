using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    class Program
    {
        static int nod(int x, int y)
        {
            double a = Math.Max(x, y);
            double b = Math.Min(x, y);
            while(a % b != 0)
            {
                int c = (int)a % (int)b;
                a = b;
                b = c;
            }
            return (int)b;
        }
        public static void Main()
        {
            int z = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[z];
            for (int k = 0; k < z; k++)
            {
                int x = Convert.ToInt32(ss[k]);
                a[k] = x;
            }
            if (z == 1)
            {
                Console.Write(a[0]);
            }
            else
            {
                int Nod = 0;
                for (int i = 0; i < z - 1; i++)
                {
                    Nod = nod(a[i], a[i + 1]);
                    a[i + 1] = Nod;
                }
                Console.Write(Nod);
            }
        }
    }
}
