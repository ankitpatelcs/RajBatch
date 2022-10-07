using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemoCore.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoCore.Areas.Users.Controllers
{
    [Area("Users")]
    public class DefaultController : Controller
    {
        private ecommerceContext dc = null;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DefaultController(ecommerceContext _dc, IHttpContextAccessor httpContextAccessor)
        {
            dc = _dc;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["password"];

            var data = dc.TblUsers.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("UserId", data.UserId.ToString());
                _httpContextAccessor.HttpContext.Session.SetString("UserName", data.FName);
                return RedirectToAction("HomePage");
            }
            ViewBag.loginerror = "Invalid email or password";
            return View();
        }

        public IActionResult Logout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("UserId");
            _httpContextAccessor.HttpContext.Session.Remove("UserName");
            _httpContextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("HomePage");
        }
        public IActionResult HomePage()
        {
            return View();
        }
        
        public IActionResult Products()
        {
            return View(dc.Tblproducts.ToList());
        }

        public IActionResult Single(int id)
        {
            return View(dc.Tblproducts.Find(id));
        }
        
        public string AddToCart(int id)
        {
            int userid = Convert.ToInt32(_httpContextAccessor.HttpContext.Session.GetString("UserId"));
            Tblcart obj = new Tblcart();
            obj.ProductId = id;
            obj.Qty = 1;
            obj.UserId = userid;

            dc.Tblcarts.Add(obj);
            dc.SaveChanges();

            return "Product Added to Cart.";
        }

        public IActionResult Cart()
        {
            int userid = Convert.ToInt32(_httpContextAccessor.HttpContext.Session.GetString("UserId"));
            return View(dc.Tblcarts.Where(x=>x.UserId==userid).ToList());
        }
    }
}
