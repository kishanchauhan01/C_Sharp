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
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j< arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the element at {i} {j}");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();


            for (int i=0; i< arr.GetLength(0); i++)
            {
                for(int j=0; j< arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}