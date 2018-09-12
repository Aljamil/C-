using System;

public class AbstractClassTest
{
	public static void Main(string[] args)
	{
		SalariedEmployee employee1 = new SalariedEmployee("John", "Smith", 
			"111-11-1111", 800.00M);
		HourlyEmployee employee2 = new HourlyEmployee("Karen", "Price", 
			"222-22-2222", 16.75M, 40.0M);
		CommissionEmployee employee3 = new CommissionEmployee("Sue", "Jones",
			"333-33-3333", 10000.00M, .06M);
		BasePlusCommissionEmployee employee4 = new BasePlusCommissionEmployee("Bob", 
			"Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

		Console.WriteLine("Process different Employees.");

		Console.WriteLine("{0}Earned: {1:C}\n", employee1, employee1.Earnings());
		Console.WriteLine("{0}Earned: {1:C}\n", employee2, employee2.Earnings()); 
		Console.WriteLine("{0}Earned: {1:C}\n", employee3, employee3.Earnings()); 
		Console.WriteLine("{0}Earned: {1:C}\n", employee4, employee4.Earnings());  
	}
}