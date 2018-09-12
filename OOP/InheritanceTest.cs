using System;

public class InheritanceTest
{
	public static void Main(string[] args)
	{
	   BasePlusCommissionEmployee employee1 = new BasePlusCommissionEmployee("Al", "Arazas", 
	   	"111-11-1111", 5000.00M, .04M, 300.00M);

	   Console.WriteLine("Employee Information");
	   Console.WriteLine(employee1);
	   Console.WriteLine("Earnings are {0:C}", employee1.Earnings());

	   Console.WriteLine();

	   employee1.BaseSalary = 1000.00M;

	   Console.WriteLine("Updated profile information.");
	   Console.WriteLine(employee1);
	   Console.WriteLine("Update earnings: {0:C}.", employee1.Earnings());
	}
}