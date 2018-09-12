
//Concrete Derive Class BasePlusCommissionEmployee

using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
   private decimal baseSalary;

   public BasePlusCommissionEmployee(string first, string last,
   	string ssn, decimal sales, decimal rate, decimal salary)
    : base(first, last, ssn, sales, rate)
    {
       BaseSalary = salary;
    }

    public decimal BaseSalary
    {
    	get
    	{
    		return baseSalary;
    	}

    	set 
    	{
    		if(value >= 0)
    		    baseSalary = value;
    		else
    		   throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
    	}
    }

    public override decimal Earnings()
    {
    	return baseSalary + base.Earnings();
    }

    public override string ToString()
    {
    	return string.Format("Base Salaried {0}Base Salary: {1:C}\n", base.ToString(), BaseSalary);
    }


}