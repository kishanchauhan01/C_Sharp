using System;

public class Class1
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 45, 85, 96 };
        int s = 0;
        int e = arr.Length - 1;
        int mid = (s + e) / 2;

        Console.WriteLine("enter key: ");
        int key = Int32.Parse(Console.ReadLine());

        while (s < e)
        {
            if (arr[mid] == key)
            {
                Console.WriteLine("Item found with index" + mid);
                break;
            }

            if (arr[mid] < key)
            {
                s = mid + 1;
            }

            if (arr[mid] > key)
            {
                e = mid - 1;
            }

            mid = (s + e) / 2;
        }
    }
}
