using System;

namespace SimpleCodeHW17
{
    class HW17
    {
        static void Main(string[] args)
        {
            int value = 782;
            Sum(value);
        }

        static void Sum(int n, int count = 0)
        {
            int sum = count + n%10;
            count = sum;
            n = n / 10;
            if (n == 0)
            {
                Console.WriteLine(sum);
                return;
            }
            Sum(n, count);
        }
    }
}
