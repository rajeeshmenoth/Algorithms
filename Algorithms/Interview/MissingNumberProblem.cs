using System;

namespace Algorithms.Interview
{
    public static class MissingNumberProblem
    {
        /// <summary>
        /// Find missing number in an array.
        /// </summary>
        public static void FindMissingNumberInAnArray()
        {
            // The array contains natural number and the sequence in n + 1.
            int[] array = { 1, 4, 3, 5, 6 };
            int totalElements = array.Length;
            int sum = 0;
            int total = (totalElements + 1) * (totalElements + 2) / 2;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Missing number in an array is : {total - sum}");
        }
    }
}
