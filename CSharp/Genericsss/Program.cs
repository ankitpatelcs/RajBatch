using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsss
{
    class MyClass<Type1,Type2>
    {
        Type1 id;
        Type2 name;

        public MyClass(Type1 i, Type2 n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Value1: {0}",id);
            Console.WriteLine("Value2: {0}",name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, string> m = new MyClass<int, string>(102,"Raj");
            m.display();

            MyClass<string, DateTime> m2 = new MyClass<string, DateTime>("Nikhilesh",DateTime.Now);
            m2.display();

            Console.Read();
        }
    }
}
