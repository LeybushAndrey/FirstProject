using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklSdvigVpravo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке

            string s = Console.ReadLine(); // сохранить всю введенную строку

            string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа
            int[] numbers = new int[n]; // заводим новый массив целого типа

            for (int i = 0; i < n; i++) // так как у нас в массиве n чисел, то проходим по нему циклом
            {
                int number = Convert.ToInt32(ss[i]); // конвертируем в число
                numbers[i] = number; // записываем в соответствующее место сконвертированное число
            }
            Console.Write(numbers[n - 1] + " ");
            for (int a = 0; a < n - 1; a++)
            {
                Console.Write(numbers[a] + " ");
            }
        }
    }
}
