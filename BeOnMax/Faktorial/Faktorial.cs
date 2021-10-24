using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorial
{
    class Faktorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления его факториала");
            int a = int.Parse(Console.ReadLine());
            for (int i = (a-1); i > 0; i--)
            {
                a = a * i;
            }
            Console.WriteLine($"Факториал числа а = {a}");
        }
    }
}
