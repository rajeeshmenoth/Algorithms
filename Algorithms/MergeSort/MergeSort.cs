using System;

namespace Algorithms
{
    public class MergeSort
    {
        /// <summary>
        /// Merge sorting with two sorted arrays
        /// </summary>
        public static void MergeSortWithTwoArray()
        {
            // Sorted array A
            int[] A = new int[] { 2, 5, 6, 8 };
            // Sorted array B
            int[] B = new int[] { 10, 12, 22, 35 };

            // Finding the length of array A & array B
            int lenthOfArrayA = A.Length;
            int lenthOfArrayB = B.Length;

            // Initialize starting point of all three arrays.
            int i = 0;
            int j = 0; 
            int k = 0;

            // Auxiliary array using for storing merged array.
            int[] C = new int[lenthOfArrayA + lenthOfArrayB];

            while (i < lenthOfArrayA && j < lenthOfArrayB)
            {
                if (A[i] < B[j])
                {
                    C[k++] = A[i++];
                }
                else
                {
                    C[k++] = B[j++];
                }
            }

            for (; i < lenthOfArrayA; i++)
            {
                C[k++] = A[i];
            }

            for (; j < lenthOfArrayB; j++)
            {
                C[k++] = B[j];
            }

            Console.WriteLine($"Merge Sorting using two arrays : [{string.Join(",", C)}]");
        }

        /// <summary>
        /// Recursive mechanism
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lower"></param>
        /// <param name="high"></param>
        public static void RecursiveMergeSort(int[] array, int lower, int high)
        {
            int mid;
            if (lower < high)
            {
                //middle portion of the array
                mid = (lower + high) / 2;
                //leftside portion of the array
                RecursiveMergeSort(array, lower, mid);
                //right side portion of the array
                RecursiveMergeSort(array, mid+1, high);
                //merging two arrays into one
                RecursiveMerge(array, lower, mid, high);
            }
            
        }

        /// <summary>
        /// Base concepts of divide and conquer method.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lower"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        private static void RecursiveMerge(int[] array, int lower, int mid, int high)
        {
            int i = lower;
            int j = mid + 1;
            int k = lower;
            int[] auxiliary = new int[array.Length];

            while (i <= mid && j <= high)
            {
                if(array[i] < array[j])
                {
                    auxiliary[k++] = array[i++];
                }
                else
                {
                    auxiliary[k++] = array[j++];
                }
            }

            for(;i <= mid; i++)
            {
                auxiliary[k++] = array[i];
            }

            for (; j <= high; j++)
            {
                auxiliary[k++] = array[j];
            }

            for (i = lower; i <= high; i++)
            {
                array[i] = auxiliary[i];
            }

            

        }
    }
}
