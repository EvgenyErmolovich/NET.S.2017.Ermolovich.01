using System;

namespace Sort
{
	public static class Sorting
	{
		/// <summary>
		/// QuickSort
		/// </summary>
		/// <param name="arr">Array to sort</param>
		public static void QSort(int[] arr)
		{
			ValidInput(arr);
			QuickSort(arr, 0, arr.Length - 1);
		}
		/// <summary>
		/// MergeSort
		/// </summary>
		/// <param name="a">Array to sort</param>
		public static void MSort(int[] a)
		{
            ValidInput(a);
			MergeSort(a, 0, a.Length - 1);
		}
		/// <summary>
		/// Logic of QuickSort
		/// </summary>
		/// <param name="arr">Array to sort</param>
		/// <param name="left">The first element</param>
		/// <param name="right">The last elelment.</param>
		private static void QuickSort(int[] arr, int left, int right)
		{
			int i = left, j = right;
			int tmp;
			int middle = arr[(left + right) / 2];
			while (i <= j)
			{
				while (arr[i] < middle)
					i++;
				
				while (arr[j] > middle)
					j--;

				if (i <= j)
				{
					tmp = arr[i];
					arr[i] = arr[j];
					arr[j] = tmp;
					i++;
					j--;
				}
			};

			if (left < j)
				QuickSort(arr, left, j);
			if (i < right)
				QuickSort(arr, i, right);
		}
		/// <summary>
		/// Logic of merging two arrays
		/// </summary>
		/// <param name="a">Array to sort</param>
		/// <param name="first">First element</param>
		/// <param name="last">Last element</param>
		private static void Merge(int[] a, int first, int last)
		{
			int middle, start, final, j;
			int[] mas = new int[100];

			middle = (first + last) / 2;
			start = first;
			final = middle + 1;

			for (j = first; j <= last; j++)
			if ((start <= middle) && ((final > last) || (a[start] < a[final])))
			{
				mas[j] = a[start];
				start++;
			}
			else
			{
				mas[j] = a[final];
				final++;
			}

			for (j = first; j <= last; j++) 
				a[j] = mas[j];
		}
		/// <summary>
		/// Merges the sort.
		/// </summary>
		/// <param name="a">The alpha component.</param>
		/// <param name="first">First.</param>
		/// <param name="last">Last.</param>
		private static void MergeSort(int[] a, int first, int last)
		{
			{
				if (first < last)
				{
					MergeSort(a, first, (first + last) / 2);
					MergeSort(a, ((first + last) / 2) + 1, last);
					Merge(a, first, last);
				}
			}
		}
		/// <summary>
		/// Valids the input
		/// </summary>
		/// <param name="a">Array to check</param>
		private static void ValidInput(int[] a)
		{
			if (a == null) throw new ArgumentNullException("Null");
			if (a.Length == 0) throw new ArgumentException("Array is empty");
		}
	}
}
