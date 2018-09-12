using System;

public class DateTest
{
	public static void Main(string[] args)
	{
	   int hour, minute, second, month, day, year;

	   Console. Write("Enter a value for hour: ");
       hour = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for minute: ");
       minute = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for second: ");
       second = Convert.ToInt32(Console.ReadLine());

       Time t1 = new Time(hour, minute, second);

       Console. Write("Enter a value for month: ");
       month = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for day: ");
       day = Convert.ToInt32(Console.ReadLine());

       Console. Write("Enter a value for year: ");
       year = Convert.ToInt32(Console.ReadLine());

       Date myDate = new Date(month, day, year, t1);

       Console.WriteLine(myDate);


	}
}