using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=50;
            if (a>50)
            {
                Console.WriteLine("Greater");
            }
            else if (a<50)
            {
                Console.WriteLine("lessor");
            }
            else if (a==50)
            {
                Console.WriteLine("Equal");
            }

            Console.Read();
        }
    }
}
