using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MergeSort
    {
        public static void MergeSortWithTwoArray()
        {
            int[] A = new int[] { 2, 5, 6, 8 };
            int[] B = new int[] { 10, 12, 22, 35 };

            int lenthOfArrayA = A.Length;
            int lenthOfArrayB = B.Length;

            int i = 0;
            int j = 0; 
            int k = 0;

            //Auxiliary array
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
    }
}
