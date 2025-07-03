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

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 5; i++)
            // {
            //     for(int j=0; j < 5-i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //     Console.WriteLine();
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                int k = i;
                for (int j = 0; j <= k; j++)
                {
                    if(k<=5)
                    {
                        Console.Write("*");
                    }
                   
                }
                Console.WriteLine();
            }



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

        }
    }
}
