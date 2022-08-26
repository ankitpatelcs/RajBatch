using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteDataValues.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.controller = RouteData.Values["Controller"];
            ViewBag.action = RouteData.Values["Action"];
            ViewBag.id = RouteData.Values["Id"];
            return View();
        }
    }
}
