using System;

namespace HighestAndLowest
{
    class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string[] str = numbers.Split(' ');
            int[] newNumbers = new int[str.Length];
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = 0; i < str.Length; i++)
            {
                int newNumber = Convert.ToInt32(str[i]);
                newNumbers[i] = newNumber;
                if (newNumbers[i] < min)
                    min = newNumbers[i];
                if (newNumbers[i] > max)
                    max = newNumbers[i];
            }
           
            string high = max.ToString();
            string low = min.ToString();
            string HighLow = high + " " + low;
    return HighLow;
        }
        static void Main(string[] args)
        {
            string numbers = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";
            Console.WriteLine(HighAndLow(numbers));
        }
    }
}
