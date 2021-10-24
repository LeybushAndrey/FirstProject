using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevertish
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;
            for (int index = countChar - 1; index >= 0; index--)
            {
                Console.Write(s[index]);
            }
        }
    }
}
