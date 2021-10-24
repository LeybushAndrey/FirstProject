using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdinstvElem
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
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numbers[i] == numbers[j]&& i !=j)
                    {
                        c++;
                    }
                }
                if(c ==0)
                {
                    Console.Write(numbers[i] + " ");
                }
                c = 0;
                continue;
            }
        }
    }
}
