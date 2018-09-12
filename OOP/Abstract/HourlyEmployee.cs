// Concrete Derived Class HourlyEmployee

using System;

public class HourlyEmployee : Employee
{
	private decimal wage;
	private decimal hours;

	public HourlyEmployee(string first, string last, string ssn, 
		decimal hourlyWages, decimal hoursWorked) : base(first, last, ssn)
		{
			Wage = hourlyWages;
			Hours = hoursWorked;
		}

     public decimal Wage 
	 {
		get
		{
			return wage;
		}

		set 
		{
			if(value >= 0)
			   wage = value;
			else
			  throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
		}
	}

	public decimal Hours  
	 {
		get
		{
			return hours;
		}

		set 
		{
			if(value >= 0 && value <= 168)
			   hours = value;
			else
			  throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
		}
	}

	public override decimal Earnings()
	{
		if(Hours <= 40)
		 return Wage * Hours;
		else
		  return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
	}

	public override string ToString()
	{
		return string.Format("Hourly Employee: {0}\n{1}: {2:C}\n{3}: {4:C}\n",
			base.ToString(), "Hourly Wage", Wage, "Hours Worked", Hours);
	} 
}