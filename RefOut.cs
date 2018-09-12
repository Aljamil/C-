using System;

public class RefOut
{
	public static void Main(string[] args)
	{
       int y = 5;
       int z;


       SquareRef(ref y);
       SquareOut(out z);

       Console.WriteLine("Value of y after SquareRef: {0}.", y);
       Console.WriteLine("Value of z after SquareOut {0}.\n", z);

       Square(y);
       Square(z);
       

       Console.WriteLine("Value of y after Square: {0}.", y);
       Console.WriteLine("Value of z after Square: {0}.\n", z);


       Console.WriteLine(Math.Sqrt(1296));

	}

	static void SquareRef(ref int x)
	{
		x *= x;
	}

	static void SquareOut(out int x)
	{
		x = 6;
		x = x * x;
	}

	static void Square(int x)
	{
		x = x * x;

		//Console.WriteLine("The value of z: {0}", x);
	}
}