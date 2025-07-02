using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //Console.WriteLine("Enter string value: ");
            //str = Console.ReadLine();
            //Console.WriteLine("String is: " + str);

            //int no1;
            //int no2;

            //Console.WriteLine("Enter two numbers no1 and no2: ");

            //no1 = Convert.ToInt32(Console.ReadLine());
            //no2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("First number is: "+no1);
            //Console.WriteLine("secod number is: "+no2);

            //for(int i=0; i<=100; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            string str1, str2, str3;
            Console.WriteLine("Enter string 1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2: ");
            str2 = Console.ReadLine();
            Console.WriteLine("Enter string 3: ");
            str3 = Console.ReadLine();
            Console.WriteLine("Length of string 1 is: " + str1.Length);
            Console.WriteLine("String 2 in lower case: " + str2.ToLower());
            Console.WriteLine("String 3 in upper case: " + str3.ToUpper());

            //Combine or concate two strings
            str3 = str1 + str2;
            Console.WriteLine("Combine strings is: " + str3);
            //using concate method
            str3 = string.Concat(str1, "", str2);
            Console.WriteLine("Combine string using concate method is: " + str3);
            //interploation of string

            int no = 100;
            str3 = $"Multiplication of number is: {no * 10}";
            Console.WriteLine("String 3 is: " + str3);
        }
    }
}
