using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentDemo.EDM;

namespace ViewComponentDemo.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext dc = null;
        public DefaultController(CompanyContext _dc)
        {
            dc = _dc;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult display()
        {
            return View(dc.Tblemployees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tblemployee obj)
        {
            dc.Tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
