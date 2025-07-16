using System;

namespace first
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command Line Argument");
            Console.WriteLine("First argument "+args[0]);
            Console.WriteLine("Second argument "+ args[1]);

            foreach(string i in args)
            {
                Console.WriteLine("Command Line argument " + i);
            }

        }
    }
}