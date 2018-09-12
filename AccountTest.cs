using System;

public class AccountTest
{
	public static void Main(string[] args)
	{
		Account account1 = new Account(75.00M);

		decimal deposit;

		Console.WriteLine("The initial balance is {0:C}.", account1.Balance);

        Console.Write("Enter the amount to deposit: ");

        deposit = Convert.ToDecimal(Console.ReadLine());

        account1.Credit(deposit);

        Console.WriteLine("The current balance is {0:C}.", account1.Balance);
	}
}