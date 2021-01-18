﻿using System;

namespace Algorithms.FibonacciSeries
{
    public static class FibonacciSeries
    {
        public static void FibonacciSeriesAlgorithm()
        {
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write($"{c},");
            }

            
        }
    }
}
