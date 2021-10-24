using System;

namespace SimpleCodeHW15
{
    class HW15
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 3, 2 };
            PrintArray(myArray);
        }

        static void PrintArray(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return;
            }
            Console.Write(array[index] + " ");
            index++;
            PrintArray(array, index);
        }
    }
}
