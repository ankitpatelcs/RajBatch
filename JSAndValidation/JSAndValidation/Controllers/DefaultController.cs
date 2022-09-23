using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSAndValidation.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult dtpicker()
        {
            return View();
        }
        
        public IActionResult nivos()
        {
            return View();
        }
        public IActionResult bval()
        {
            return View();
        }
        public IActionResult dataval()
        {
            return View();
        }
    }
}
