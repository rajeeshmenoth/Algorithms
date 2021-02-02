using System;

namespace Algorithms.Basics
{
    public static class ReverseAString
    {
        /// <summary>
        /// Reversing a string
        /// </summary>
        /// <param name="content"></param>
        public static void ReverseString(string content)
        {
            char[] charArray = content.ToCharArray();
            string rev = string.Empty;
            for (int i = content.Length - 1; i > -1; i--)
            {
                rev += charArray[i];
            }

            Console.WriteLine($"The reverse string of given content {content} is {rev}");
        }
    }
}
