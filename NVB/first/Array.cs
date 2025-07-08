using System;

public class Array1
{
    //A collection of elements
    //Store multiple values into a single var
    //Elements are from the same type only
    //store elements in contiguous space
    //elements can be accessible through its index values
    //index values begin from 0 and its up to n-1 (n is number of elements)
    //types:-
    //One dimensional
    //multi dimensional
    //jagged array
    public static void Main(string[] args)
    {
        //int[] arr = new int[10];
        //arr[0] = 10;
        //      arr[1] = 20;

        //      arr[2] = 40;
        //      arr[3] = 50;

        ////Console.WriteLine(arr[0]);
        //      foreach (var i in arr)
        //      {
        //	Console.WriteLine(i);
        //      }
        //int[] arr = new int[5];

        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = new int[5];

        Console.WriteLine("Enter the numbers");
        for(int i=0; i<arr2.Length; i++)
        {
            arr2[i] = Int32.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (int i in arr2)
        {
            sum += i;
        }

        Console.WriteLine($"The average is: {sum/arr2.Length}");

        int i = 0;
        while (i < arr1.Length)
        {
            int j = arr1[i];
            arr1[i] = 
        }

    }


}
