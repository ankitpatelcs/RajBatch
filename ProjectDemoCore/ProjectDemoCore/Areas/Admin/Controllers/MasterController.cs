using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemoCore.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterController : Controller
    {
        private ecommerceContext dc = null;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public MasterController(ecommerceContext _dc, IHttpContextAccessor httpContextAccessor)
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

            var data = dc.TblAdmins.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("AdminId", data.AdminId.ToString());
                _httpContextAccessor.HttpContext.Session.SetString("AdminName", data.FName);
                return RedirectToAction("Dashboard");
            }
            ViewBag.loginerror = "Invalid email or password";
            return View();
        }

        public IActionResult Logout()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        
        public IActionResult AddProductc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProductc(Tblproduct obj)
        {
            dc.Tblproducts.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("ManageProducts");
        }
        public IActionResult ManageProducts()
        {
            return View(dc.Tblproducts.ToList());
        }
    }
}
