using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancess
{
    class Employee
    {
        int id;
        string name;
        protected void Getemp()
        {
            id = 23;
            name = "Raj";
        }
        protected void showemp()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
    class Payroll : Employee
    {
        int salary;
        internal void GetData()
        {
            Getemp();
            salary = 25000;
        }
        internal void ShowData()
        {
            showemp();
            Console.WriteLine("Salary: "+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetData();
            p.ShowData();

            Console.Read();
        }
    }
}
