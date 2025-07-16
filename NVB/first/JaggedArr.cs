using System;

namespace first
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[][] jArr = new int[7][];

            jArr[0] = new int[1];
            jArr[1] = new int[2];
            jArr[2] = new int[3];
            jArr[3] = new int[4];
            jArr[4] = new int[3];
            jArr[5] = new int[2];
            jArr[6] = new int[1];


            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    Console.WriteLine($"Enter number in {i} {j}");
                    jArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            //for (int i = jArr.Length-1; i > -1; i--)
            //{
            //    for (int j = 0; j < jArr[i].Length; j++)
            //    {
            //        Console.Write($"{jArr[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i<jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    Console.Write($"{jArr[i][j]} ");
                }
                Console.WriteLine();
            }

            //searching

            int key = 2;
            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    if(jArr[i][j] == key)
                    {
                        Console.Write($"element found at {i} {j}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}