using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            //string name;
            Console.Write("Enter Number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number B: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Name: ");
            //name = Console.ReadLine();
            c = a + b;

            Console.WriteLine("Addition of {1} and {0} is {2}",a,b,c);

            Console.Read();
        }
    }
}
