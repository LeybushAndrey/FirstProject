using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calc
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double firsValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Введите число 1");
                    firsValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }
           
                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firsValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firsValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firsValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firsValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Ошибка! Неизвестное действие");
                }
                Console.ReadLine();
            }
        }
    }
}
