/*
 * two d array 
 * int[][] arr = [[1,2,3], [1,2,5]]
 * 
 */

using System;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] sum = new int[3, 3];

            Console.WriteLine("Enter numbers for arr1");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the element at {i} {j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter numbers for arr2");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the element at {i} {j}");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = arr[i, j] + arr2[i, j];
                }
            }

            Console.WriteLine("Sum of both arrays: ");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write($"{sum[i, j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}