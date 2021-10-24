using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisks
{
    class Asterisks
    {
        static void Main(string[] args)
        {
            Task.PrintAsterisks(10);
        }
    }
    class Task
    {
        public static void PrintAsterisks(uint x)
        {
            for (int i = 1; i <= x; i++)
                Console.Write("*");
        }
    }
}
