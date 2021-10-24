using System;

namespace SimpleCodeHW16
{
    class HW16
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 3, 2 };
            SumArray(myArray);
        }

        static void SumArray(int[] array, int index = 0, int count = 0)
        {
            int sum = count + array[index];
            count = sum;
            if (index == array.Length - 1)
            {
                Console.WriteLine(sum);
                return;
            }
            SumArray(array, index + 1, count);
        }
    }
}
