using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Recursion
{
    public static class Recursion
    {
		/// <summary>
		/// Recursion method ascending order.
		/// </summary>
		/// <param name="n"></param>
		public static void RecursionAscending(int n)
		{
			if (0 < n)
			{
				// first print the value then recursion will trigger.
				Console.WriteLine($"Ascending order : {n}");
				RecursionAscending(n - 1);
			}
		}

		/// <summary>
		/// Recursion method descending order.
		/// </summary>
		/// <param name="n"></param>
		public static void RecursionDescending(int n)
		{
			if (0 < n)
			{
				// first recursion then print the value.
				RecursionDescending(n - 1);
				Console.WriteLine($"Descending order : {n}");
			}
		}
	}
}
