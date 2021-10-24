using System;

namespace Sum
{
    class Sum
    {
        static public int GetSum(int a, int b)
        {
            int sum = 0;
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            if (a == b)
                return a;
            for (int i = min; i < max + 1; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = -3;
            Console.WriteLine(GetSum(a, b));
        }
    }
}
