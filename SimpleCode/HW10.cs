using System;

namespace HW1
{
    class HW10
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            PrintLine(a, s);
        }

        static void PrintLine(int a, string s) 
        {
            for(int i = 0; i < a; i++)
            Console.Write(s);
        }
    }
}
