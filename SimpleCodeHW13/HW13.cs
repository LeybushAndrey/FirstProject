using System;

namespace SimpleCodeHW13
{
    class HW13
    {
        static void Main(string[] args)

        
        {
            int[] myArray = { 1, 4, 6, 2 };

            FirstIndex(ref myArray, 5);

            LastIndex(ref myArray, 7);

            AnyIndex(ref myArray, 3, 9);
        }

        static void FirstIndex(ref int[] array, int firstValue)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 1; i < array.Length + 1; i++)
            {
                newArray[0] = firstValue;
                newArray[i] = array[i - 1];
            }

            array = newArray;
        }

        static void LastIndex(ref int[] array, int lastValue)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = lastValue;
            array = newArray;
        }

        static void AnyIndex(ref int[] array, int index, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                    newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }
    }
}
