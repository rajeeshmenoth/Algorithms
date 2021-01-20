using System;

namespace Algorithms.Factorial
{
    public static class Factorial
    {
        /// <summary>
        /// Finding the factorial of given element
        /// </summary>
        /// <param name="element">any number</param>
        public static void FactorialMethod(int element)
        {
            int number = 1;
            for (int i = 1; i <= element; i++)
            {
                number = number * i;
            }

            Console.WriteLine($"Factorial of {element} is {number}");
        }
    }
}
