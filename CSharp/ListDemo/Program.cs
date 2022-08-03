using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1, fname="Raj", email="R@gmail.com" });
            li.Add(new Employee { empid=2, fname="Nikhilesh", email="N@gmail.com" });

            foreach (var item in li)
            {
                Console.WriteLine("\nID: "+item.empid);
                Console.WriteLine("Name: "+item.fname);
                Console.WriteLine("Email: "+item.email);
            }

            Console.Read();
        }
    }
}
