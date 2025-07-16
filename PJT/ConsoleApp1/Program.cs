using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // patten 1
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // // patten 2
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // // patten 3
            //for (int i = 0; i < 5; i++)
            // {
            //     for(int j=0; j < 5-i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //     Console.WriteLine();
            //}

            // // patten 4
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // // patten 5
            //for (int i = 0; i < 9; i++)
            //{
            //    int k = i < 5 ? i + 1 : 9 - i;

            //    for (int j = 0; j < k; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


            // // patten 6
            //for (int i=1; i<=5; i++)
            //{
            //    int j = 0;
            //    for(; j<5-i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    while(j != 5)
            //    { 
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();

            //}

            // // 

            // // patten 7 - pyramid
            //Console.WriteLine("Enter the number: ");
            //int row = Int32.Parse(Console.ReadLine());

            //for(int i=0; i<row; i++)
            //{
            //    int space = 1;
            //    while(space < row-i)
            //    {
            //        Console.Write(" ");
            //        space++;
            //    }

            //    int j = 1;

            //    while(j <= 2*i-1)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }

            //    Console.WriteLine();
            //}

            // //table 1 to 10
            //for(int i=1; i<11; i++)
            //{
            //    for(int j=1; j<11; j++)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}

            // // using one loop
            //int i = 1;
            //int j = 1;

            //while (true)
            //{
            //    if (j == 11)
            //    {
            //        i++;
            //        j = 1;
            //        Console.WriteLine();
            //    }

            //    if (i == 11)
            //    {
            //        break;
            //    }

            //    if (j < 11)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //        j++;
            //    }


            //}

            //int a = 5;
            //int b = 5;
            //int res = ++a + b++ + b++ + a++;    
            //Console.WriteLine(res);
            //Console.WriteLine(a + " " + b);

            //a = 127;
            //b = 127;
            //byte result = unchecked((byte)(a * b));
            //Console.WriteLine(result);

            //int ip = 4;
            int num = 5;
            int sum = 0;

             int j = 1;
            for(int i=0; i<4; i++)
            {
                sum += num;
                int tempsum = sum;
                j *= 10;
                int temp = 5 * j;
                num += temp;
            }
            Console.WriteLine(sum);

        }
    }
}
