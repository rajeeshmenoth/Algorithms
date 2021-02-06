using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Basics
{
    public static class MinAndMax
    {
        /// <summary>
        /// Finding a minimum and maximum sum value in an given array.
        /// </summary>
        /// <param name="array"></param>
        public static void MinAndMaxSumInAnArray(int[] array)
        {
            long minimumSumResult = 0;
            long maximumSumResult = 0;
            // Find minimum value in an array using linq.
            int minimumValue = array.Min();
            // Find maximum value in an array using linq.
            int maximumValue = array.Max();

            for (int i = 0; i < array.Length; i++)
            {
                minimumSumResult += array[i];
                maximumSumResult += array[i];
            }

            Console.WriteLine($"Minimum Sum {minimumSumResult - minimumValue} , Maximum Sum {maximumSumResult - maximumValue}");
        }
    }
}
