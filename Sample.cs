using System;

public class Sample
{
	public static void Main(string[] args)
	{
	   int[] arr;
	   //int[] arr1 = {1,2,3,4,5};
	   int size;

	   Random rand = new Random();

	   Console.Write("Enter the size: ");
	   size = Convert.ToInt32(Console.ReadLine());

	   arr = new int[size];

	   for (int i = 0; i < arr.Length; i++)
	   {
           arr[i] = rand.Next(1,100);

         Console.Write("{0} ", arr[i]);
	   }

	   Console.WriteLine();

	   modifyArray(arr);

	   Console.WriteLine("The new elements after modifying an array: ");

	   foreach (int i in arr)
	   {
	   	  Console.Write("{0} ", i);
	   }

	   Console.WriteLine();

	   modifyElement(arr[3]);


	   foreach (int i in arr)
	   {
	   	  Console.Write("{0} ", i);
	   }

	   Console.WriteLine();
	}

	public static void modifyArray(int[] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
		  arr[i] *= 2;
		}
	}

	public static void modifyElement(int arr)
	{
       arr *= 2;
       Console.WriteLine("The new element is {0}.", arr);
	}
}