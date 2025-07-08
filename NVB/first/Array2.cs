using System;

public class Class1
{
	public static void Main(string[] args)
	{
		int[] arr = { 10,20,55,60,778,98};

		int max = arr[0];

		foreach(int i in arr)
		{
			if(i > max)
			{
				max = i;
			}
		}

		Console.WriteLine($"max number is {max}");
	}
}
