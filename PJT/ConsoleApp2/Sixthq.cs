using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    //class Line
    //{
    //    private double length;

    //    public Line()
    //    {

    //        Console.WriteLine("Object is being created, Length: 10");

    //    }

    //    public void setLength(double length)
    //    {
    //        this.length = length;
    //    }

    //    public double getLength()
    //    {
    //        return this.length;
    //    }
    //}
    //internal class Sixthq
    //{
    //    static void Main(string[] args)
    //    {
    //        Line l = new Line();
    //        l.setLength(12.5);
    //        Console.WriteLine("Length of line: " + l.getLength());
    //        l.setLength(5.247);
    //        Console.WriteLine("Length of line: " + l.getLength());

    //    }
    //}

    class Product

    {


        String pcode, pname, mname;




        public Product(string pcd, String pnm, String mnm)

        {

            mname = mnm;
            pcode = pcd;

            pname = pnm;

        }



        public void Display()

        {

            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
            return;

        }

    }

    public class TestProduct

    {

        public static void Main(string[] args)

        {

            int n = args.Length;



            if (n < 3)

            {

                Console.WriteLine("Syntax Error\n");

                Console.WriteLine("Must Have THREE Arguments\n");

                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");

            }

            else

            {



                Product p = new Product(args[0], args[1], args[2]);

                p.Display();

                Console.Read();

                int pcd = Convert.ToInt32(args[0]);

                String pnm = args[1];

                String mnm = args[2];



            }

        }

    }
}
