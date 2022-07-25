using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        int empid;
        string name;

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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Getdata();
            e.display();

            Console.Read();
        }
    }
}
