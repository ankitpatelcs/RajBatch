using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Shape
    {
        internal void area(double r)
        {
            Console.WriteLine("Area of Circle: {0}", 3.14 * r * r);
        }
        internal void area(int a)
        {
            Console.WriteLine("Area of square: {0}", a * a);
        }
        internal void area(int l,int b)
        {
            Console.WriteLine("Area of square: {0}", l * b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.area(10);
            s.area(5.5);
            s.area(50,5);

            Console.Read();
        }
    }
}
