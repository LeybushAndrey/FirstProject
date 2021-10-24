using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            int b = int.Parse(Console.ReadLine());

            double Max = Math.Max((double)a, b);

            Console.WriteLine(Max);
        }
    }
}
