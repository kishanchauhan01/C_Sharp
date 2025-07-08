using System;

public class Class1
{

    //public void swap(int i, int j, ref int[] arr)
    //{
    //	int temp = i;
    //	arr[i] = j;
    //	arr[j] = temp;
    //}

    public static void Main(string[] args)
    {
        //int[] arr = { 5, 2, 10, 7, 3 };

        //for(int i=0; i<arr.Length; i++)
        //{
        //	for(int j=i+1; j<arr.Length; j++)
        //	{
        //		if (arr[i] > arr[j])
        //		{
        //			int temp = arr[i];
        //			arr[i] = arr[j];
        //			arr[j] = temp;


        //			//swap(arr[i], arr[j], ref arr[0]);
        //		}
        //	}
        //}

        //foreach(int i in arr)
        //{
        //	Console.WriteLine(i);
        //}

        int[] arr1 = { 2, 3, 2, 1, 2, 3 };

        bool[] freq = new bool[arr1.Length];

        for(int i=0; i<arr1.Length; i++)
        {
            if (freq[i] == true) continue;
            int cnt = 1;

            for(int j=i+1; j<arr1.Length; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    freq[j] = true;
                    cnt++;
                }
            }

            Console.WriteLine($"Frequency of {arr1[i]} is {cnt}");
        }

        foreach(bool i in freq)
        {
            Console.WriteLine(i);
        }

    }


}
