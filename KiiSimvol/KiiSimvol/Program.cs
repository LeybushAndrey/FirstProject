using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiiSimvol
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            if (k <= s.Length)
            {
                Console.Write(s[k - 1]);
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
