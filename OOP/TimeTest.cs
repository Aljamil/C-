using System;

public class TimeTest
{
	public static void Main(string[] args)
	{
       int hour, minute, second;

       Console. Write("Enter a value for hour: ");
       hour = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for minute: ");
       minute = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for second: ");
       second = Convert.ToInt32(Console.ReadLine());

	   Time t1 = new Time();
	   Time t2 = new Time(hour);
	   Time t3 = new Time(hour, minute);
	   Time t4 = new Time(hour, minute, second);
	   Time t5 = new Time(t4);
	   Time t6;

	   Console.WriteLine("The time for t1. (DEFAULT)");
	   Console.WriteLine(t1.toUniversal());
	   Console.WriteLine(t1.ToString());

	   Console.WriteLine("The time for t2.");
	   Console.WriteLine(t2.toUniversal());
	   Console.WriteLine(t2.ToString());

	   Console.WriteLine("The time for t3.");
	   Console.WriteLine(t3.toUniversal());
	   Console.WriteLine(t3.ToString());

	   Console.WriteLine("The time for t4.");
	   Console.WriteLine(t4.toUniversal());
	   Console.WriteLine(t4.ToString());

	   Console.WriteLine("The time for t5.");
	   Console.WriteLine(t5.toUniversal());
	   Console.WriteLine(t5.ToString());

	   try
	   {
	   	  t6 = new Time(27, 74, 99);
	   }
	   catch ( ArgumentOutOfRangeException ex)
	   {
	   	  Console.WriteLine("\nException while initializing t6:");
	   	  Console.WriteLine(ex.Message);
	   }

	   
	}
}