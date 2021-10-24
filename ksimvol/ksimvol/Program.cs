using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksimvol
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            int countChar = s.Length;
            for (int index = 0; index <= countChar - 1; index++)
            {
                if (index != k - 1)
                 {
                     Console.Write(s[index]);
                 }
            }
        }
    }
}
