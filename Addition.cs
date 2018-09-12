using System;


public class Add
{
	 public static void Main(String[] args)
    {
    	int a;
    	int b;

    	Console.Write("Enter integer 1: ");
    	a = Convert.ToInt32(Console.ReadLine() );

    	Console.Write("Enter integer 2: ");
    	b = Convert.ToInt32(Console.ReadLine() );

    	int sum = a + b;

    	Console.WriteLine("The sum is {0}.", sum);
    }
}