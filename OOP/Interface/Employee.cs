
// Abstract class Employee implements Ipayable

public abstract class Employee : IPayable
{
	public string FirstName {get; private set; }

	public string LastName {get; private set; }

	public string SocialSecurityNumber {get; private set; }

	public Employee(string first, string last, string ssn)
	{
		FirstName = first;
		LastName = last;
		SocialSecurityNumber = ssn;
	}

	public override string ToString()
	{
		return string.Format("{0}, {1}\nSocial Security Number: {2}", FirstName,
			LastName, SocialSecurityNumber);
	}

	public abstract decimal GetPaymentAmount();
}