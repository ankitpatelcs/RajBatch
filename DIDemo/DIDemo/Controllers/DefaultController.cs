using DIDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IVisitorCount _count;
        public DefaultController(IVisitorCount count)
        {
            _count = count;
        }

        public IActionResult Index([FromServices] IVisitorCount _cnt)
        {
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();

            ViewBag.cnt = _cnt.GetCount();
            
            return View();
        }
    }
}
