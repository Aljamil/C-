

using System;

public class GradeBookTest
{
	public static void Main(string[] args)
	{
		string nameCourse;

        Console.Write("Enter the name of course: ");

		nameCourse = Console.ReadLine();

		Gradebook myGBook = new Gradebook(nameCourse);

		Console.WriteLine("Welcome to the course {0}.!", myGBook.CourseName);
	}
}
