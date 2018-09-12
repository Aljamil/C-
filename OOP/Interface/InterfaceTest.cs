//Test IPayable Interface class

using System;

public class InterfaceTest
{
	public static void Main(string[] args)
	{
	  IPayable[] payables = new IPayable[4];

	  payables[0] = new Invoice("01234", "Seat", 2, 375.00M);
	  payables[1] = new Invoice("56789", "Tire", 4, 79.95M);
	  payables[2] = new SalariedEmployee("John", "Smith", 
	  	"111-11-1111", 800.00M);
	  payables[3] = new SalariedEmployee("Lisa", "Barnes", 
	  	"888-88-8888", 1200.00M);

	  Console.WriteLine("Process the Invoice and Employees polymorphically!\n");

	  foreach (var i in payables)
	  {
	  	  Console.WriteLine("{0}\nPayment Due: {1:C}.\n", i, i.GetPaymentAmount() );
	  }


	}
}