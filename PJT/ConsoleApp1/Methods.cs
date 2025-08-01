using System;

namespace ConsoleApp1
{

    /// <summary>
    /// this class is for swaping the variablees
    /// </summary>

    public class Class1
    {
        /// <summary>
        /// This a variable for storing the int value above 100
        /// </summary>
        int a;

        static double add(double x, double y)
        {
            return x + y;
        }

        static double subtraction(double x, double y)
        {
            return x - y;
        }

        static double multiplication(double x, double y)
        {
            return x * y;
        }

        static double division(double x, double y)
        {
            return x / y;
        }

        static void swap(ref int x, ref int y)
        {

            int temp = x;
            //x = y;
            //y = temp;
            x = x + y;
            y = x - y;
            x = x - y;
        }
        /// <summary>
        /// This method will change the value of the given parameter
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">last number</param>
        static void change(ref int a, ref int b)
        {

            a = 100;
            b = 400;
        }

        static void update(out int a, out int b)
        {
            a = 100;
            b = 200;
        }

        static void Main(string[] args)
        {

            int x = 5;
            int y = 10;

            //Console.WriteLine(add(5.1, 4));
            //Console.WriteLine(subtraction(5, 4));
            //Console.WriteLine(multiplication(5, 4.3));
            //Console.WriteLine(division(5, 0));

            //Console.WriteLine("Before swap: a = a = {0} and b = {1}", x, y);
            //swap(ref x, ref y);
            //Console.WriteLine("After swap: a = a = {0} and b = {1}", x, y); 


            Console.WriteLine("Before change: a = a = {0} and b = {1}", x, y);
            change(x, y);
            update(out x, out y);
            Console.WriteLine("After change: a = a = {0} and b = {1}", x, y); 
        }
    }
}
