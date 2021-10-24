using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormirovanieStroki
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;
            int n = 0;
            for (int i = 0; i <= countChar - 1; i++)
            {
                if (s[i] != ' ')
                {
                    Console.Write(s[i]);
                    continue;
                }
                else
                {
                    if (s[i + 1] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(s[i]);
                    }
                }
            }
        }
    }
}
