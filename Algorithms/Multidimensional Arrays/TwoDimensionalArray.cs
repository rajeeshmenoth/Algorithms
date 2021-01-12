using System;
using System.Collections.Generic;
using System.Text;

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
                                           {10, 22, 35, 8} ,   /*  initializers for row indexed by 0 */
                                           {6, 15, 26, 37} ,   /*  initializers for row indexed by 1 */
                                           {5, 16, 38, 81}     /*  initializers for row indexed by 2 */
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
    }
}
