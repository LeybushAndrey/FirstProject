using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPairs
{
    class CheckPairs
    {
        static void Main(string[] args)
        {
            Task.CheckPairs("Console.ReadLine();", '(', ')'); /* Все в порядке */
        }
    }
    class Task
    {
        public static void CheckPairs(string s, char a, char b)
        {
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == a)
                    c++;
                if (s[i] == b && c > 0)
                    c--;
                else
                 if (s[i] == b && c == 0)
                {
                    c = 1;
                    break;
                }
            }
            if (c == 0)
                Console.WriteLine("Все в порядке");
            else
                Console.WriteLine("Найдены ошибки");
        }
    }
}
    
