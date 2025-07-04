using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            //var d = 7;

            Console.WriteLine("Enter the number: 1 ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number: 2 ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of {a} + {b} = {a + b}");


        }
    }
}
