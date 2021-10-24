using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinakovieBukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;
            for (int index = 0; index <= countChar - 1; index++)
            {
                for (int i = 0 / 2; i < index; i++)
                {
                    if (s[index] == s[i])
                    {
                        Console.Write(s[i]);
                    }
                }
            }
        }
    }
}
