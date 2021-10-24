using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSquare
{
    class ChessSquare
    {
        static void Main(string[] args)
        {
            int straw1 = int.Parse(Console.ReadLine());
            int column1 = int.Parse(Console.ReadLine());
            int straw2 = int.Parse(Console.ReadLine());
            int column2 = int.Parse(Console.ReadLine());
            int deltastraw = (int)Math.Abs(straw1 - straw2);
            int deltacolumn = (int)Math.Abs(column1 - column2);
            int deldel = (int)Math.Abs(deltastraw - deltacolumn);
            if ((deldel % 2) == 0)
                Console.Write("yes");
            else
                Console.Write("no");
        }
    }
}
