using System;

public class TestReferenceArray
{
	public static void Main(string[] args)
	{
	   int[] firstArray = {1,2,3};

	   int[] firstArrayCopy = firstArray; 

	   Console.WriteLine("TEST PASSING REFERENCE BY VALUE.");

	   firstDouble(firstArray);

	   for(int i = 0; i < firstArray.Length; i++)
	   {
	   	 Console.Write("{0} ", firstArray[i]);
	   }

	   Console.WriteLine();

	   for(int i = 0; i < firstArrayCopy.Length; i++)
	   {
	   	 Console.Write("{0} ", firstArrayCopy[i]);
	   }

	   Console.WriteLine();


	   int[] secondArray = {1,2,3};

	   int[] secondArrayCopy = secondArray;

       Console.WriteLine("TESTING PASSING REFERENCE BY REFERENCE");

       secondDouble(ref secondArray);

       for(int i = 0; i < secondArray.Length; i++)
	   {
	   	 Console.Write("{0} ", secondArray[i]);
	   }

	   Console.WriteLine();

	   for(int i = 0; i < secondArrayCopy.Length; i++)
	   {
	   	 Console.Write("{0} ", secondArrayCopy[i]);
	   }

	   Console.WriteLine();

	}

	public static void firstDouble(int[] array)
	{
		for(int i = 0; i < array.Length; i++)
		{
			array[i] *= 2;
		}

		array = new int[] {11,12,13};
	}

	public static void secondDouble(ref int[] array)
	{
		//array = new int[] {11,12,13};
		
		for(int i = 0; i < array.Length; i++)
		{
			array[i] *= 2;
		}

		array = new int[] {11,12,13};

		
	}
}