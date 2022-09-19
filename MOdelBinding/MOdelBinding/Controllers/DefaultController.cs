using Microsoft.AspNetCore.Mvc;
using MOdelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOdelBinding.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("f_name,email,salary")] Employee obj)
        {
            return View();
        }
    }
}
