using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("Calling from BaseClass");
        }
    }
    class Payroll : Employee
    {
        override public void display()
        {
            Console.WriteLine("Calling from Derived Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.display();

            Console.Read();
        }
    }
}
