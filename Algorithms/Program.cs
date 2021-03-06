﻿using Algorithms.Basics;
using Algorithms.Interview;
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

            #region Binary Search
            Console.WriteLine();
            Console.WriteLine("Binary Search");
            int[] binarySearchArray = new int[] { 2, 8, 12, 22, 35, 88, 100 };
            Console.WriteLine($"The index of given element in a Binary Search is : {BinarySearch.BinarySearch.BinarySearchAlgorithm(binarySearchArray, binarySearchArray.Length, 88)}");
            #endregion

            #region Bubble Sort
            Console.WriteLine();
            Console.WriteLine("Bubble Sort!");
            int[] bubbleSortArray = new int[] { 10, 8, 12, 22, 100, 88, 101, 4 };
            BubbleSort.BubbleSort.BubbleSortAlgorithm(bubbleSortArray, bubbleSortArray.Length);
            #endregion

            #region Count Sort
            Console.WriteLine();
            Console.WriteLine("Count Sort!");
            CountSort.CountSort.CountSortAlgoritm();
            #endregion

            #region Fibonacci Series
            Console.WriteLine();
            Console.WriteLine("Fibonacci Series!");
            FibonacciSeries.FibonacciSeries.FibonacciSeriesAlgorithm();
            #endregion

            #region Factorial
            Console.WriteLine();
            Console.WriteLine("Factorial !!");
            Factorial.Factorial.FactorialMethod(5);
            #endregion

            #region Recursion
            Console.WriteLine("Recursion Ascending & Descending Sorting");
            Recursion.Recursion.RecursionSort(3);
            #endregion

            #region Reverse a String
            Console.WriteLine();
            Console.WriteLine("Reverse a String !!");
            Basics.ReverseAString.ReverseString("rajeesh");
            #endregion

            #region Missing number problem in an array
            MissingNumberProblem.FindMissingNumberInAnArray();
            #endregion


            #region MinAndMax Array Problems
            Console.WriteLine("Minimum and Maximum Problems in an Arrays!");
            int[] arrayElement = { 10, 88, 1, 55, 48 };
            MinAndMax.MinAndMaxSumInAnArray(arrayElement);
            int[] arrMinAndMax = { 3, 10, 2, 5, 7, 10 };
            MinAndMax.FindMaxValueCountInAnArray(arrMinAndMax);
            #endregion

            Console.WriteLine();
            Console.WriteLine("Multidimensional Arrays!");
            #region Multidimensional Array
            TwoDimensionalArray.ReplaceDiagonalWithStar();
            Console.WriteLine("Matrix Rotation");
            TwoDimensionalArray.NinetyDegreeMatrixRotation();
            #endregion



            
            Console.ReadLine();

        }
    }
}
