using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widespread
{
    class Widespread
    {
        static void Main(string[] args)
        {
            string mostWidespread = Task.GetMostWidespread(new[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
            Console.WriteLine(mostWidespread); // Emperor Penguin
        }
    }
    class Task
    {
        public static string GetMostWidespread(string[] penguin)
        {
            string s = penguin[0];
            int c = 0;
            int d = 0;
            for (int i = 0; i < (penguin.Length - 1); i++)
            {
                c = 0;
                for (int j = (i + 1); j < penguin.Length; j++)
                {
                    if (penguin[i] == penguin[j])
                        c++;
                }
                if (c >= d)
                {
                    d = c;
                    s = penguin[i];
                }
            }
            return s;
        }
    }
}
