using System;

public class Time
{
	private int hour;
	private int minute;
	private int second;

	public Time(int h = 0, int m = 0, int s = 0)
	{
		setTime(h,m,s);
	}

	public Time(Time time) : this(time.Hour, time.Minute, time.Second){}

	public void setTime(int h, int m, int s)
	{
		Hour = h;
		Minute = m;
		Second = s;
	}

	public int Hour
	{
       get
       {
       	 return hour;
       }

       set
       {
         if(value >= 0 && value < 24)
           hour = value;
         else
           throw new ArgumentOutOfRangeException(
           	"Hour", value, "Hour must be 0-23");
       }
	}

	public int Minute
	{
       get
       {
       	 return minute;
       }

       set
       {
         if(value >= 0 && value < 60)
           minute = value;
         else
           throw new ArgumentOutOfRangeException(
           	"Minute", value, "Minute must be 0-23");
       }
	}

	public int Second
	{
       get
       {
       	 return second;
       }

       set
       {
         if(value >= 0 && value < 60)
           second = value;
         else
           throw new ArgumentOutOfRangeException(
           	"Second", value, "Second must be 0-23");
       }
	}

	public string toUniversal()
	{
		return string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
	}

	public override string ToString()
	{
		return string.Format("{0}:{1:D2}:{2:D2} {3} \n", ( (Hour == 0 || Hour == 12) ? 12 : Hour % 12), Minute, Second, (Hour < 12 ? "AM" : "PM") );
	}


	
}