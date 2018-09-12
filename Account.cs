public class Account
{
	private decimal balance;

	public decimal Balance
	{
       set
       {
       	  if(value >= 0)
           balance = value;
       }

       get
       {
       	  return balance;
       }
	}

	public void Credit(decimal amount)
	{
		Balance = Balance + amount; 
	}

	public Account(decimal initialDecimal)
	{
		Balance = initialDecimal;
	}
}