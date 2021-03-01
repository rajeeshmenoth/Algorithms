using System;
using System.Text;

namespace Algorithms.Recursion
{
    public static class Recursion
    {
		private static StringBuilder Descending { get; set; } = new StringBuilder();
		private static StringBuilder Ascending { get; set; } = new StringBuilder();
		/// <summary>
		/// Recursion method ascending & descending order.
		/// </summary>
		/// <param name="element"></param>
		public static void AscendingAndDescendingOrder(int element)
		{
			if (0 < element)
			{
				Descending.Append(element);
				AscendingAndDescendingOrder(element - 1);
				Ascending.Append(element);
			}
		}

		/// <summary>
		/// Recursion method.
		/// </summary>
		/// <param name="element"></param>
		public static void RecursionSort(int element)
		{
			AscendingAndDescendingOrder(element);
			Console.WriteLine($"Ascending Order: {string.Join(",", Ascending)}");
			Console.WriteLine($"Descending Order: {string.Join(",", Descending)}");
		}
	}
}
