using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Student
    {
        int rollNo;
        String name;
        static int studentSrNo = 1;

        public Student()
        {
            Console.WriteLine("Enter details for student " + Student.studentSrNo);
            Console.WriteLine("Enter Roll no: ");
            rollNo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Student.studentSrNo++;
        }

        public Student(int rollNo, String name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }

        public Student(Student s)
        {
            this.rollNo = s.rollNo;
            this.name = s.name;
        }

        static Student()
        {
            Console.WriteLine("Static called");
        }

        public void showData()
        {
            Console.WriteLine();
            Console.WriteLine("Roll number is: " + rollNo);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine();
        }
    }
    internal class Constructors
    {
        static void Main(string[] args)
        {
            Student []s = new Student[2];
            
            //s[0] = new Student();

            for(int i =0; i<s.Length; i++)
            {
                s[i] = new Student();
            }

            for (int i = 0; i < s.Length; i++)
            {
                s[i].showData();
            }


            //Student s1 = new Student(7, "Kishan");
            //s1.showData();

            //Student s2 = new Student(4, "Ansh");
            //s2.showData();

            //int rollno = 21;
            //string name = "Jay";
            //Student s3 = new Student(rollno, name);
            //s3.showData();

            //Student s4 = new Student(s1);
            //s4.showData();

        }
    }
}
