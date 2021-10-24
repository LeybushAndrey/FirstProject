using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;
            for (int index = 0; index <= countChar; index++)
            {
                if (s[index] == 'x')
                {
                    Console.Write("x");
                    break;
                }
                if(s[index] == 'w')
                {
                    Console.Write("w");
                    break;
                }
                if (s[countChar-1] != 'x' && s[countChar-1] != 'w')
                {
                    Console.Write("-1");
                    break;
                }
            }
            
        }
    }
}
