using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDes
{
    class Employee
    {
        int empid;
        string name;

        public Employee()
        {
            empid = -1;
            name = "-";
        }

        public Employee(int empid,string name)
        {
            this.empid = empid;
            this.name = name;
        }

        public void Getdata()
        {
            empid = 89;
            name = "Raj";
        }

        public void display()
        {
            Console.WriteLine("Employee ID: " + empid);
            Console.WriteLine("Name: " + name);
        }

        ~Employee()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(34,"Henil");
            //e.Getdata();
            e.display();

            Console.Read();
        }
    }
}
