using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifikator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countChar = s.Length;
            string a = "NO";
                if((s[0] == '_') || (s[0] >= 'A' && s[0] <= 'Z') || (s[0] >= 'a' && s[0] <= 'z'))
                {
                    for (int index = 0; index <= countChar - 1; index++)
                    {
                        if((s[index] == '_') || (s[index] >= 'A' && s[index] <= 'Z') || (s[index] >= 'a' && s[index] <= 'z') || (s[index] >= '0' && s[index] <= '9'))
                        {
                            a = "YES";
                        }
                        else
                        {
                         a = "NO";
                         break;
                        }
                }
                }
            Console.Write(a);
        }
    }
}
