
//Test Polymorphism

using System;

public class PolymorphismTest
{
	public static void Main(string[] args)
	{
		CommissionEmployee employee1 = new CommissionEmployee("Sue", "Jones",
			"222-22-2222", 10000.00M, .06M);

		BasePlusCommissionEmployee employee2 = new BasePlusCommissionEmployee("Bob", "Lewis", 
			"3333-33-3333", 5000.00M, .04M, 300.00M);

		Console.WriteLine("Calling CommissionEmployee details and earnings.\n");

		Console.WriteLine(employee1);
		Console.WriteLine("Earnings: {0:C}\n", employee1.Earnings());

		Console.WriteLine("Calling BasePlusCommissionEmployee details and earnings.\n");

		Console.WriteLine(employee2);
		Console.WriteLine("Earnings: {0:C}\n", employee2.Earnings());

		Console.WriteLine();

		CommissionEmployee employee3 = employee2;

		Console.WriteLine("Calling BasePlusCommissionEmployee details and earnings with base class reference to derived class.\n");

		Console.WriteLine(employee3);
		Console.WriteLine("Earnings: {0:C}\n", employee3.Earnings());
	}
}