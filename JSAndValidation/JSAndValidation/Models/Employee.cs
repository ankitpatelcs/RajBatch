using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSAndValidation.Models
{
    public class Employee
    {
        public string f_name { get; set; }
        public string email { get; set; }        
        public string mobile { get; set; }
        public int salary { get; set; }
        public string gender { get; set; }

    }
}
