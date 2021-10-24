using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaastAlfavita
{
    class Program
    {
        static void Main(string[] args)
        {
            char s = Convert.ToChar(Console.ReadLine());
            char s1 = Convert.ToChar(Console.ReadLine());
            char a = s;
           char b = s1;
            if(s < s1)
            {
                a = s;
                b = s1;
            }
            else
            {
                a = s1;
                b = s;
            }
            for(char x = a; x <= b; x++)
            {
                Console.Write(x + " ");
            }
        }
    }
}
