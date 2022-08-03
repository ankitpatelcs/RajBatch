using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    public delegate void FirstDelegate();

    class MyClass
    {
        public void display()
        {
            Console.WriteLine("Calling Display");
        }
        public void show()
        {
            Console.WriteLine("Calling Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            FirstDelegate fdel = new FirstDelegate(m.display);
            fdel += new FirstDelegate(m.show);  //multicasting

            fdel.Invoke();

            fdel -= new FirstDelegate(m.display);
            fdel.Invoke();

            Console.Read();
        }
    }
}
