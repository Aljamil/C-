using System;

public class Calculate
{
	public static void Main(string[] args)
	{
		int x = 1;

		int sum = 0;

		while(x <= 10)
		{

			Console.Write("{0} ", x);
			sum += x;
			++x;
		}

		Console.WriteLine();

		Console.WriteLine("The value of sum is {0}.", sum);
	}
}