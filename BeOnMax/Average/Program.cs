using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 целых чисел, либо 0, чтобы остановить ввод.");
            int n = 10;
            int count = 0;
            int[] SeriesOfNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                SeriesOfNumbers[i] = int.Parse(Console.ReadLine());
                if (SeriesOfNumbers[i] == 0)
                    break;
                if(i == 8)
                    Console.WriteLine("Введите последнее число");
                count++;
            }
            int count1 = 0;
            int a = 0;
            for (int j = 0; j < count; j++)
            {
                if (SeriesOfNumbers[j] > 0 && (SeriesOfNumbers[j] % 3) == 0)
                {
                    a = a + SeriesOfNumbers[j];
                    count1++;
                }
            }
            double Average = (double)a / (double)count1;
            Console.WriteLine($"Среднее значение суммы чисел, кратных 3: {Average}");
        }
    }
}
