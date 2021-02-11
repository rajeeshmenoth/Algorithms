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
            // 3 rows and 4 columns
            int[,] a = new int[3, 3]    {
                                           {10, 22, 35} ,   /*  row indexed by 0 */
                                           {6, 15, 26} ,   /*  row indexed by 1 */
                                           {5, 16, 38}     /*  row indexed by 2 */
            };
            int rowLength = a.GetLength(0);
            int columnLength = a.GetLength(1);
            int matrixElements = 3;
            int[,] aux = new int[rowLength, columnLength];

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < columnLength; col++)
                {
                    //run a loop in each cycle from N – row – 1
                    aux[col, matrixElements - row - 1] = a[row, col];
                }
            }

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write(" " + aux[i, j]);
                }

                Console.WriteLine();
            }

            
        }
    }
}
