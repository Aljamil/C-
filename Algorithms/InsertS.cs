using System;

namespace Insert
{
	public class InsertS
	{
		public static void Main(string[] args)
		{
			int size;

			Random rand = new Random();

			Console.Write("Enter the size: ");
			size = Convert.ToInt32(Console.ReadLine());

			int[] arr = new int[size];

			Console.WriteLine("Unsorted Array: ");

			for(int i = 0; i < arr.Length; i++)
			{
               arr[i] = rand.Next(1, 100);
               Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();

			insertS(arr);

			Console.WriteLine("Sorted Array: ");

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();



		}

		public static void insertS(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				int insert = array[i];
				int move = i;

				while(move > 0 && array[move - 1] > insert)
				{
					array[move] = array[move - 1];
					move--;
				}

				array[move] = insert;

			}
		}
	}
}