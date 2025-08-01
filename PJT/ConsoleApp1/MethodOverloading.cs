using System;

class MethodOverloadingDemo
{
    /// <summary>
    /// This method return sum of two numbers
    /// </summary>
    /// <param name="x">number one</param>
    /// <param name="y">number two</param>
    /// <returns></returns>
    static int sum(int x, int y)
    {
        return x + y;
    }

    /// <summary>
    /// This method return the sum of three numbers
    /// </summary>
    /// <param name="x">Number one</param>
    /// <param name="y">Number two</param>
    /// <param name="z">Number three</param>
    /// <returns></returns>
    static int sum(int x, int y, int z)
    {
        return x + y + z;
    }

    /// <summary>
    /// This method return sum of decimal numbers
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    static double sum(double x, double y) 
    {
        return x + y;
    }



    static void Main(string[] args)
    {
        Console.WriteLine(sum(5, 5));
        Console.WriteLine(sum(5, 5, 10));
        Console.WriteLine(sum(5, 5.26));


    }
}

