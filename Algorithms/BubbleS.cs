using System;

namespace Bubble
{
	public class BubbleS
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

			bubbleS(arr);

			Console.WriteLine("Sorted Array: ");

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();



		}

		public static void bubbleS(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				for(int j = 0; j < array.Length - 1; j++)
				{
					if(array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}
	}
}