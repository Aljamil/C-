using System;

namespace LinearS
{
	public class LinearS
	{
		public static void Main(string[] args)
		{
			int size, k;

			Random rand = new Random();

			Console.Write("Enter the size: ");
			size = Convert.ToInt32(Console.ReadLine());

			int[] arr = new int[size];

			Console.Write("Array Elements are: ");

			for(int i = 0; i < arr.Length; i++)
			{
               arr[i] = rand.Next(1, 100);
               Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();

			Console.Write("Enter the key: ");
            k = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The key is at index {0}.", linearS(arr, k));
		}

		private static int linearS(int[] array, int key)
		{
			for(int i = 0; i < array.Length; i++)
			{
				if(array[i] == key)
				  return i;
			}

			return -1;
		}
	}
}