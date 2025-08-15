using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Students
    {
        private string name;
        private string enrollNo;

        public Students() { }
        public Students(string name, string enrollNo)
        {
            this.name = name;
            this.enrollNo = enrollNo;
        }

        public string Name
        {
            get
            {
                if (this.name == null)
                {
                    return "name is not added yet";
                }
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEnrollNo()
        {
            return this.enrollNo;
        }

        public void setEnrollNo(string enrollNo)
        {
            this.enrollNo = enrollNo;
        }

        public string EnrollNo
        {
            get
            {
                if (this.enrollNo == null)
                {
                    return "enrollment number is not added yet";
                }
                return this.enrollNo;
            }

            set
            {
                enrollNo = value;
            }
        }

        static void Main(string[] args)
        {
            //Students s1 = new Students();
            ////s1.Name = "kishan";
            ////s1.EnrollNo = "23SOECE11009";
            //Console.WriteLine(s1.Name);
            ////Console.WriteLine(s1.EnrollNo);

            Students s2 = new Students();
            s2.setName("kishan");
            s2.setEnrollNo("23SOECE110");
            Console.WriteLine(s2.getName());
            Console.WriteLine(s2.getEnrollNo());


        }
    }
}
