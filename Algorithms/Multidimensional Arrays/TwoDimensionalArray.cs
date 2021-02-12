using System;

namespace Algorithms.Multidimensional_Arrays
{
    public static class TwoDimensionalArray
    {
        /// <summary>
        /// Finding diagonal in 2D array and replacing with * or any number.
        /// </summary>
        public static void ReplaceDiagonalWithStar()
        {
            Console.WriteLine("Finding diagonal in 2D array and replacing with *.");

            // 3 rows and 4 columns
            int[,] a = new int[3, 4]    {
                                           {10, 22, 35, 8} ,   /*  row indexed by 0 */
                                           {6, 15, 26, 37} ,   /*  row indexed by 1 */
                                           {5, 16, 38, 81}     /*  row indexed by 2 */
                                        };
            // Elements in the array like rows counts.
            int totalElements = 3;

            for (int i = 0; i < totalElements; i++)
            {
                for (int j = 0; j < totalElements; j++)
                {
                    // All diagonels are equal like ( 1,1 | 2,2 ) 
                    if(i == j)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Clock wise matrix rotation or 90 degree rotation.
        /// </summary>
        public static void NinetyDegreeMatrixRotation()
        {
            // 4 rows and 4 columns
            int[,] array = new int[4, 4] {
                                            { 1, 2, 3, 4 },
                                            { 5, 6, 7, 8 },
                                            { 9, 10, 11, 12 },
                                            { 13, 14, 15, 16 }
                                          };

            int matrixElements = 4;

            for (int j = 0; j < matrixElements; j++)
            {
                for (int i = matrixElements - 1; i >= 0; i--)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
