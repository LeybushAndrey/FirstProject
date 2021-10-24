using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int s1 = 1;
            while(k != 1)
            {
                for(int i = 2; i < k; i++)
                {
                    if(k % i == 0)
                    {
                        s = s + i;
                    }
                    for(int i1 = 2; i1 < s; i1++)
                    {
                        if(s % i1 == 0)
                        {
                            s1 = s1 + i1;
                        }
                    }
                    if (k == s1 && s1 != s)
                    {
                        Console.WriteLine(s1 + " " + s);
                    }
                }
                k--;
                s = 1;
                s1 = 1;
            }
        }
    }
}
