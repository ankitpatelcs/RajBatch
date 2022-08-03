using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> di = new Dictionary<string, object>();
            di.Add("ID", 102);
            di.Add("Name", "Raj");
            di.Add("Salary", 55000.5);
            di.Add("Gender", 'M');

            foreach (var item in di)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.Read();
        }
    }
}
