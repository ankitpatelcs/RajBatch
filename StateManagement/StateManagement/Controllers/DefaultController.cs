using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        public IHttpContextAccessor _contextAccessor;
        public DefaultController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public IActionResult Cookies()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(2);
            _contextAccessor.HttpContext.Response.Cookies.Append("username", "Raj",options);
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.data = _contextAccessor.HttpContext.Request.Cookies["username"].ToString();
            return View();
        }
        public IActionResult ShowMsg(string name,int id)
        {
            ViewBag.msg = name;
            return View();
        }

        public IActionResult Login()
        {
            _contextAccessor.HttpContext.Session.SetString("uname","Raj");
            return View();
        }

        public IActionResult svar()
        {
            ViewBag.msg = "Message from ViewBag";
            ViewData["info"] = "Message from ViewData";
            TempData["data"] = "Displaying TempData";
            return View();
        }

        public IActionResult Second()
        {
            return View();
        }
    }
}
