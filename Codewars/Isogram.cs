using System;

namespace Codewars
{
    class Isogram
    {

        public class Kata
        {
            public static bool IsIsogram(string str)
            {
                bool test = true;
                str = str.ToLower();
                for (int i = 0; i < str.Length-1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] != str[j])
                            continue;
                        else
                            test = false;
                    }
                }
                return test;
            }
        }
        static void Main(string[] args)
        {
            if(Kata.IsIsogram("moOse") == true)
                Console.WriteLine("Изограм");
            else
                Console.WriteLine("Не изограм");
        }
    }
}
