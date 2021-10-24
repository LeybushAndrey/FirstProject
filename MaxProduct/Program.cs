using System;

namespace MaxProduct
{
    class Program
    {
        static int maxproduct(int n, string x, int m, string y)
        {
            int amax = 0;
            int bmax = 0;
            string[] xx = x.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(xx[i]);
                a[i] = number;
                amax = a[0];
                while (i > 0 && i < (n - 1))
                {
                    amax = Math.Max(a[i], a[i + 1]);
                }
            }
            string[] yy = y.Split(' ');
            int[] b = new int[m];
            for (int j = 0; j < m; j++)
            {
                int number1 = Convert.ToInt32(yy[j]);
                b[j] = number1;
                bmax = b[0];
                while (j > 0 && j < (m - 1))
                {
                    bmax = Math.Max(b[j], b[j + 1]);
                }
            }
            int product = amax * bmax;
            return product;

        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            string y = Console.ReadLine();
            Console.WriteLine(maxproduct(n, x, m, y));
        }
    }
}
