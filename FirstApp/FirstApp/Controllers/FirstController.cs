using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmpInfo()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1,fname="Nikhilesh",mobile="9876", email="n@gmail.com" });
            li.Add(new Employee { empid=2,fname="Raj",mobile="69281", email="r@gmail.com" });
            li.Add(new Employee { empid=3,fname="Jaydeep",mobile="72364", email="j@gmail.com" });
            return View(li);
        }
    }
}
