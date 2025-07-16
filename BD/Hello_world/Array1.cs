using System;
using System.Linq;

public class Class1
{
	static void Main(string[] args)
	{
		//int[] a = { 1, 2, 3, 4, 5 };

		//string[] arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

		//Console.WriteLine("Enter the number");

		//string numbers = Console.ReadLine();

		//foreach(char num in numbers )
		//{
		//	Console.WriteLine(arr[Int32.Parse(num.ToString())] + " ");

		//}

		int[] arr = { 45, 25, 65, 20 };
		int max = Int32.MinValue;
		int min = Int32.MaxValue;

		foreach(int i in arr)
		{
			if(i > max)
			{
				max = i;
			}
			if(i < min)
			{
				min = i;
			}
		}

		Console.WriteLine(max);
        Console.WriteLine(min);




    }

}
