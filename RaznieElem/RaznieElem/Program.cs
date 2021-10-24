using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaznieElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
            string s = Console.ReadLine(); // сохранить все введенную строку
            string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                numbers[i] = number;
            }
            int c = 1;
            for (int i = 1; i < n; i++)
            {
                    if (numbers[i] != numbers[i - 1])
                    {
                        c++;
                    }
            }
            Console.Write(c);
        }
    }
}
