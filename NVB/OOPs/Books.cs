using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class BooksDetail
    {
        private int bookId;
        private string bookTitle;
        private string bookAuthor;
        private int bookPrice;

        public BooksDetail()
        {
            Console.WriteLine("Enter book id: ");
            bookId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter book title: ");
            bookTitle = Console.ReadLine();
            Console.WriteLine("Enter book author name: ");
            bookAuthor = Console.ReadLine();
            Console.WriteLine("Enter book price: ");
            bookPrice = int.Parse(Console.ReadLine());

        }

        public void showData()
        {
            Console.WriteLine("Book id: " + bookId);
            Console.WriteLine("Book name: " + bookTitle);
            Console.WriteLine("Book author: " + bookAuthor);
            Console.WriteLine("Book price: " + bookPrice);
            Console.WriteLine();

        }

    }

    class Employees
    {
        private int empId;
        private string empName;

        public Employees()
        {
           
            empId = Int32.Parse(args[0]);
            empName = args[1];
        }

        public void showData()
        {
            Console.WriteLine("empId is " + empId);
            Console.WriteLine("employee name is " + empName);

        }
    }
    internal class Books
    {

        static void Main(string[] args)
        {
            //BooksDetail b1 = new BooksDetail();
            //b1.showData();

            //BooksDetail b2 = new BooksDetail();
            //b2.showData();

            //BooksDetail b3 = new BooksDetail();
            //b3.showData();

            //BooksDetail b4 = new BooksDetail();
            //b4.showData();

            //BooksDetail b5 = new BooksDetail();
            //b5.showData();

            Employees e1 = new Employees();
            e1.showData();

        }
    }
}
