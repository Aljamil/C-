using System;

namespace Select
{
	public class SelectS
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

			selectS(arr);

			Console.WriteLine("Sorted Array: ");

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();



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
	}
}