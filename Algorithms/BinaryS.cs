using System;

namespace Binary
{
	public class BinaryS
	{
		public static void Main(string[] args)
		{
			int size, k;

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

			selectS(arr);

			Console.WriteLine("Sorted Array: ");

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();

			Console.Write("Enter the key: ");
			k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("The key is found at index {0}.", binaryS(arr, k));



		}

		public static void selectS(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				int min = i;

				for(int j = i + 1; j < array.Length; j++)
				{
					if(array[min] > array[j])
					{
					   min = j;
					}
				}
                
                if(i < min)
                {
                	int temp = array[i];
                	array[i] = array[min];
                	array[min] = temp;
                }

			}
		}

		private static int binaryS(int[] array, int key)
		{
			int high = array.Length;
			int low = 0;
			int mid = (low + high) / 2;

			while(low <= high)
			{
				if(array[mid] == key)
				{
				   return mid;
				}
				else if(array[mid] > key)
				{
				    high = mid - 1;
				}
				else
				{
				    low = mid + 1;
				}

                mid = (low + high) / 2;

			}

			return -1;
		}
	}
}