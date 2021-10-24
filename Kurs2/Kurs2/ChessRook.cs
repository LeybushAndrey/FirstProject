using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs2
{
    class ChessRook
    {
        static void Main(string[] args)
        {
            int straw1 = int.Parse(Console.ReadLine());
            int column1 = int.Parse(Console.ReadLine());
            int straw2 = int.Parse(Console.ReadLine());
            int column2 = int.Parse(Console.ReadLine());
            if (straw1 == straw2 || column1 == column2)
                Console.Write("yes");
            else
                Console.Write("no");
        }
    }
}
