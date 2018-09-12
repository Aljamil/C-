using System;

public class Gradebook
{
	//private string courseName;

	public string CourseName{ set; get;}

    public Gradebook(string name)
    {
    	CourseName = name;
    }


	public void displayMessage()
	{
		Console.WriteLine("Welcome to {0} course!", CourseName);
	}
}

