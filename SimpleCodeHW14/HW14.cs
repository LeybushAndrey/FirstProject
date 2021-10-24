using System;

namespace SimpleCodeHW14
{
    class HW14
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2 };
            DeleteLast(ref myArray);
        }

        static void DeleteIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length - 1; i++)
                newArray[i] = array[i + 1];

            array = newArray;
        }

        static void DeleteFirst(ref int[] array)
        {
            DeleteIndex(ref array, 0);
        }

        static void DeleteLast(ref int[] array)
        {
            DeleteIndex(ref array, array.Length - 1);
        }
    }
}
