using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if((((k % m) == 0) || ((k % n) == 0)) && ((m * n) > k))
                Console.Write("yes");
            else
                Console.Write("no");
        }
    }
}
