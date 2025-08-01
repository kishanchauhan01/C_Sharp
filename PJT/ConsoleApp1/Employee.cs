using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {



        public int empId;
        public string name;
        public string city;

        public Employee()
        {

        }

        public Employee(int empId, string name)
        {
            this.empId = empId;
            this.name = name;
        }

        public Employee(int empId, string name, string city) : this(empId, name)
        {
            this.city = city;
        }

        //public void display()
        //{

        //}

        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(1, "kishan");
            Employee e2 = new Employee(2, "chauhan", "Rajkot");
            Console.WriteLine(e2.name, e2.empId, e2.city);

        }

    }

}
