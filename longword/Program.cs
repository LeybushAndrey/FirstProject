using System;

namespace longword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                int v = s.Length - 2;
                string a = v.ToString();
                if (s.Length <= 10)
                    Console.WriteLine(s);
                else
                    Console.WriteLine( s[0] + a + s[s.Length - 1]);
            }
        }
    }
}
