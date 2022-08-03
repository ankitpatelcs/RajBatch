using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHdlg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                a = 10;
                b = 0;
                c = a / b;
                throw new OverflowException("array overflow");
                Console.WriteLine("this line will not execute");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Exception Handled: " + ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Read();
            }            
        }
    }
}
