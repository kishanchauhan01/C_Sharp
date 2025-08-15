using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string firstname;
        //private string lastname;

        public string getFirstName()
        {
            return firstname;
        }

        public void setFirstName(string firstname)
        {
            this.firstname = firstname;
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.setFirstName("kishan");
                Console.WriteLine(s.getFirstName());

                Student s2 = new Student();
                s2.FirstName = "Chauhan";
                Console.WriteLine(s2.FirstName);
            }
        }
    }
}
