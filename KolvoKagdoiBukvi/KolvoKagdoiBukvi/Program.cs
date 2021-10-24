using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolvoKagdoiBukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            for (char a = 'a'; a <= 'z'; a++)
            {
                count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == a)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(a + " " + count);
                }
            }
        }
    }
}
