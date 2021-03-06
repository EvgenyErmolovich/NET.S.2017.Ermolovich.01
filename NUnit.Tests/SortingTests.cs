﻿using NUnit.Framework;
using System;
using Sort;

namespace Sort.Tests
{
	[TestFixture()]
	public class SortingTests
	{
		[TestCase(1, 3, 4, 2, 0, -5)]
		[TestCase(1, 2, 0, 2, 2, -123)]
		[TestCase(5, 4, 3, 2, 1, 0, -1)]
		public static void QSort_PositiveTests(params int[] arr)
		{
			int[] expectedArray = new int[arr.Length];
			Array.Copy(arr,expectedArray,arr.Length);
			Array.Sort(expectedArray);
			Sorting.QSort(arr);
			Assert.AreEqual(arr,expectedArray);
		}

		[TestCase(null)]
		public static void QSort_ThrowsArgumentNullException(int[] arr)
		{
			Assert.Throws<ArgumentNullException>(() => Sorting.QSort(arr));
		}

		[TestCase(1, 3, 4, 2, 0, -5)]
		[TestCase(1, 2, 0, 2, 2, -123)]
		[TestCase(5, 4, 3, 2, 1, 0, -1)]
		public static void MSort_PositiveTests(params int[] arr)
		{
			int[] expectedArray = new int[arr.Length];
			Array.Copy(arr,expectedArray,arr.Length);
			Array.Sort(expectedArray);
			Sorting.MSort(arr);
			Assert.AreEqual(arr,expectedArray);
		}

		[TestCase(null)]
		public static void MSort_ThrowsArgumentNullException(int[] arr)
		{
			Assert.Throws<ArgumentNullException>(() => Sorting.MSort(arr));
		}
	}
}
