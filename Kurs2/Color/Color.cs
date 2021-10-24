using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color
{
    class Color
    {
        static void Main(string[] args)
        {
            Task.PrintColoredText("This text should be red", ConsoleColor.Red);
            Task.PrintColoredText("This text should be yellow", ConsoleColor.Yellow);
        }
    }
  
    // Сохраняем текущий цвет текста/ меняем цвет текста/ выводим текст/ восстанавливаем цвет текста.Этим придаем процедуре(пардон, методу) видимость осмысленности.
    class Task
    {
        public static void PrintColoredText(string txt, ConsoleColor color)
        {
            ConsoleColor saveClr = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
            Console.ForegroundColor = saveClr;
        }
    }
}
