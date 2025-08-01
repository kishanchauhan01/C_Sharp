using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Employee
    {
        int id;
        string eName;
        double salary;

        public void getData(int id, string eName, double salary)
        {
            this.id = id;
            this.eName = eName;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Emp id:" + id);
            Console.WriteLine("Emp name:" + eName);
            Console.WriteLine("Emp Salary:" + salary);
        }

        public double getSalary() { return salary; }

    }

    class Time
    {
        int hr;
        int min;
        int sec;

        public void getTime(int hr, int min, int sec)
        {
            this.hr = hr;
            this.min = min;
            this.sec = sec;
        }

        public void showTime()
        {
            Console.WriteLine("{0}:{1}:{2}", this.hr, this.min, this.sec);
        }

        public void increaseSec()
        {
            if (this.sec == 59)
            {
                if (this.min == 59)
                {
                    this.hr++;
                    this.min = 0;
                    this.sec = 0;
                }
                else
                {
                    this.min++;
                    if (this.min == 60) this.min = 0;
                    this.sec = 00;
                }
            }
            else
            {
                this.sec++;
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.getData(1, "kishan", 200000.0);

            //Console.WriteLine();
            //Employee e2 = new Employee();
            //e2.getData(2, "ansh", 150);

            ////e1.getSalary() <= e2.getSalary() ? Console.WriteLine(e1.getSalary()) : Console.WriteLine(e2.getSalary());
            //if (e1.getSalary() > e2.getSalary())
            //{
            //    e1.showData();
            //}
            //else
            //{
            //    e2.showData();
            //}

            Time t = new Time();
            t.getTime(5, 59, 59);
            t.showTime();
            t.increaseSec();
            //t.increaseSec();
            t.increaseSec();
            t.showTime();


        }
    }
}
