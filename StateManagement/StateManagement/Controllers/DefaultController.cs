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
    }
}
