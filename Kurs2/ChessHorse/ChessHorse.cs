using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHorse
{
    class ChessHorse
    {
        static void Main(string[] args)
        {
            int straw1 = int.Parse(Console.ReadLine());
            int column1 = int.Parse(Console.ReadLine());
            int straw2 = int.Parse(Console.ReadLine());
            int column2 = int.Parse(Console.ReadLine());
            int deltastraw = (int)Math.Abs(straw1 - straw2);
            int deltacolumn = (int)Math.Abs(column1 - column2);
            if ((deltastraw == 1 && deltacolumn == 2) || (deltastraw == 2 && deltacolumn == 1))
                Console.Write("yes");
            else
                Console.Write("no");
        }
    }
}
