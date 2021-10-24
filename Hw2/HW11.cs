using System;

namespace SimpleCodeHW11
{
    class HW11
    {
            static void Main(string[] args)
            {
                int[] arr = GetRandomArray(10, -20, 100);
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(FindIndex(arr, a));
            }

            static string FindIndex(int[] arr, int a)
            {
                int count = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == a)
                    {
                        count = i;
                        break;
                    }
                }
                if (count == -1)
                    return "Искомый элемент не найден!";
                else
                    return "Индекс искомого элемента: " + count;
            }
            static int[] GetRandomArray(uint length, int minValue, int maxValue)
            {
                 int[] myArray = new int[length];
                 Random random = new Random();
                     for (int i = 0; i < myArray.Length; i++)
                     {
                         myArray[i] = random.Next(minValue, maxValue);
                     }
            return myArray;
            }
    }
}
