using System;

namespace Algorithms.BubbleSort
{
    public static class BubbleSort
    {
        public static void BubbleSortAlgorith(int[] array, int arrayElementsCount)
        {
            int temp = 0;

            for (int i = 0; i < arrayElementsCount - 1; i++)
            {
                for (int j = 0; j < arrayElementsCount - 1 - i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
