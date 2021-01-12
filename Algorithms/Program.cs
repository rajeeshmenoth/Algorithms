using Algorithms.Multidimensional_Arrays;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithms!");
            #region Merge Sorting
            int[] array = { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3};
            MergeSort.MergeSortWithTwoArray();
            MergeSort.RecursiveMergeSort(array, 0, array.Length - 1);
            Console.WriteLine($"Recursive Merge Sort : [{string.Join(",", array)}]");
            #endregion

            Console.WriteLine();
            Console.WriteLine("Multidimensional Arrays!");
            #region Multidimensional Array
            TwoDimensionalArray.ReplaceDiagonalWithStar();
            #endregion
            Console.ReadLine();

        }
    }
}
