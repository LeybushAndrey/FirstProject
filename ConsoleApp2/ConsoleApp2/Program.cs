using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int b;
            int i = 0;
            for (int a = 1; a <= N; a++) // перебор чисел от 1 до N
            {
                b = a;
                while (b > 0)
                {
                    int c = b % 10;
                    if (c == 7)
                    {
                        i++;
                    }
                    b = b / 10;
                }
            }
            Console.Write(i);
        }
    }
}
