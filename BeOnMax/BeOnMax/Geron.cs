using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeOnMax
{
    class Geron
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны треугольника");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны треугольника");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(S);
        }
    }
}
