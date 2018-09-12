using System;

public class maxChar
{
	public static void Main(string[] args)
	{
        string str1;

        Console.Write("Enter the string: ");
        str1 = Console.ReadLine();

        MaxChar(str1);
	}

	private static void MaxChar(string str)
	{
		int N = str.Length;
		int count = 0;
		int cur = 1;
		char res = str[0];

		for(int i = 0; i < N; i++)
		{
			if(i < N - 1 && str[i] == str[i + 1])
			{
				cur++;
			}

			else
			{
				if(cur > count)
				{
					count = cur;
					res = str[i];
				}
              cur = 1;
			}


		}

		Console.WriteLine("The Maximum character is {0} with the length of {1}.\n",
			res, count);
	}
}