using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearch
{
    public static class BinarySearch
    {
        /// <summary>
        /// Finding the position of a given number using Binary Search Algorithm ( Sorted array should be use for binary search algorithm).
        /// </summary>
        /// <returns></returns>
        public static int BinarySearchAlgorithm(int[] array, int arrayElements, int data)
        {
            int startingPoint = 0;
            int endingPoint = arrayElements - 1;

            while(startingPoint < endingPoint)
            {
                // Finding the middle element of each divide
                int mid = startingPoint + endingPoint;

                if (array[mid] == data)
                    return mid;
                else if (data < array[mid])
                    endingPoint = mid - 1;
                else
                    startingPoint = mid + 1;
            }

            return -1; // If data is not found in the given array.
        }
    
    }
}
