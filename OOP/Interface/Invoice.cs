
//Invoice Class implements IPayable

using System;

public class Invoice : IPayable
{
	private int quantity;
	private decimal pricePerItem;

	public string PartNumber{get; set;}

	public string PartDescription{get; set;}

	public Invoice(string part, string description, int count,
		decimal price)
	{
		PartNumber = part;
		PartDescription = description;
		Quantity = count;
		PriceItem = price;
	}

	public int Quantity
	{
		get
		{
			return quantity;
		}

		set
		{
			if(value >= 0)
			   quantity = value;

			else
			   Console.WriteLine("Quantity must be >= 0");
		}
	}

	public decimal PriceItem
	{
		get
		{
			return pricePerItem;
		}

		set
		{
			if(value >= 0)
			   pricePerItem = value;

			else
			  Console.WriteLine("Price per Item must be >= 0");
		}
	}

	public override string ToString()
	{
		return string.Format("{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
			"INVOICE", "Part Number", PartNumber, PartDescription, "Quantity",
			Quantity, "Price per Item", PriceItem);
	}

	public decimal GetPaymentAmount()
	{
		return Quantity * PriceItem;
	}

	
}