using System;

namespace Abstraction
{
    //abstract class
    abstract class Shape
    {
        //abstract method
        //no direct access
        public abstract int area();
    }

    class Square : Shape
    {
        private int side;

        public Square(int x = 0)
        {
            this.side = x;
        }

        public override int area()
        {
            Console.WriteLine("Area of Square: ");
            return (side * side);
        }
    }

    class MyClass
    {
        public static void Main(string[] args)
        {
            // creating reference of Shape class
            // which refer to Square class instance
            Shape s = new Square(4);

            double result = s.area();

            Console.Write("{0}", result);
        }
    }

    
}