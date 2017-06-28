using System;
using Sort;

namespace Test
{
	class Testing
	{
		public static void Main(string[] args)
		{
			int[] array = new int[10];
			Random rand = new Random();
			for (int i = 0; i < array.Length; i++)
   				array[i] = rand.Next(0,100);
			
			for (int i = 0; i < array.Length; i++)
				Console.Write(array[i] + " ");
			
			Sorting.QSort(array);
			Console.WriteLine();

			for (int i = 0; i < array.Length; i++)
				Console.Write(array[i] + " ");

			Console.WriteLine();
			
			for (int i = 0; i<array.Length; i++)
   				array[i] = rand.Next(0,100);
			
			for (int i = 0; i<array.Length; i++)
				Console.Write(array[i] + " ");
			
			Sorting.MSort(array);
			Console.WriteLine();

			for (int i = 0; i<array.Length; i++)
				Console.Write(array[i] + " ");
		}
			
	}
}
