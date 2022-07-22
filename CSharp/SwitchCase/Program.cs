using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'l';
            switch (ch)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.WriteLine("{0} is a vowel", ch);
                    break;

                default:
                    Console.WriteLine("{0} is a Consonents", ch);
                    break;
            }
            Console.Read();
        }
    }
}
