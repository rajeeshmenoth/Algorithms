using System;
using System.Linq;

namespace Algorithms.CountSort
{
    public static class CountSort
    {
        /// <summary>
        /// Count Sort Algorithm
        /// </summary>
        public static void CountSortAlgoritm()
        {
            int i,j;
            int[] array = new int[] { 8, 10, 2, 11, 3, 7, 1, 6};

            // Finiding highest value in an array.
            int maxValue = array.Max();

            // The highest value add as a space in an array.
            int[] auxiliary = new int[maxValue + 1];

            // Add 0's in array
            for (i = 0; i < maxValue + 1; i++)
            {
                auxiliary[i] = 0;
            }

            // Increment the value in respective index.
            for (i = 0; i < array.Length; i++)
            {
                auxiliary[array[i]]++;
            }

            i = 0; j = 0;

            while (j < maxValue + 1)
            {
                if(auxiliary[j] > 0)
                {
                    array[i++] = j;
                    auxiliary[j]--;
                }
                else
                j++;

            }

            Console.WriteLine($"Count Sort result is : {string.Join(", ", array)}");

        }
    }

}