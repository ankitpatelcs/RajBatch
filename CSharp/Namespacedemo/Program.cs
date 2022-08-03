using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeServices;

namespace Namespacedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.display();

            Console.Read();
        }
    }
}
