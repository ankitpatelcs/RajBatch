using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDemoCore.EDM;
using ProjectDemoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

            //var data = dc.TblUsers.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            // select * from tblusers as n
            var data = (from n in dc.TblUsers
                        where n.Email == email && n.Password == pass
                        select n).FirstOrDefault();

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
            return View(dc.Tblcarts.Include(x => x.Product).Where(x => x.UserId == userid).ToList());
        }

        [HttpPost]
        public string UpdateCartQty(int id, int qty)
        {
            var obj = dc.Tblcarts.Find(id);
            obj.Qty = qty;

            dc.Tblcarts.Update(obj);
            dc.SaveChanges();
            return "Cart Qty updated.";
        }

        public IActionResult Checkout()
        {
            int userid = Convert.ToInt32(_httpContextAccessor.HttpContext.Session.GetString("UserId"));
            Tblorder obj = new Tblorder();
            obj.UserId = userid;
            obj.Orderdate = DateTime.Now;
            obj.Status = (byte)OrderStatusEnum.Confirmed;

            dc.Tblorders.Add(obj);
            dc.SaveChanges();

            Tblorderdetail objod;

            var cartdata = dc.Tblcarts.Where(x => x.UserId == userid).ToList();

            foreach (var item in cartdata)
            {
                objod = new();
                objod.OrderId = obj.OrderId;
                objod.ProductId = item.ProductId;
                objod.Qty = item.Qty;

                dc.Tblorderdetails.Add(objod);
                dc.SaveChanges();
                objod = null;
            }

            return RedirectToAction("Success");
        }
        public IActionResult Success()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(IFormCollection fc)
        {
            string email = fc["email"];
            //Session["emailotp"] = email;
            _httpContextAccessor.HttpContext.Session.SetString("emailotp", email);
            var obj = dc.TblUsers.Where(u => u.Email == email).FirstOrDefault();
            if (obj != null)
            {
                Random r = new Random();
                int otp = r.Next(1000, 9999);
                //Session["otp"] = otp;
                _httpContextAccessor.HttpContext.Session.SetString("otp", otp.ToString());
                SendEmail(email, "Reset password OTP", $"Reset password OTP: {otp}");
                return RedirectToAction("ValidateOTP");
            }
            ViewBag.error = "User Not Found.!";
            return View();
        }
        public ActionResult ValidateOTP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidateOTP(IFormCollection fc)
        {
            string otp = fc["textotp"];

            if (otp == _httpContextAccessor.HttpContext.Session.GetString("otp").ToString())
            {
                return RedirectToAction("ResetPassword");
            }
            ViewBag.error = "OTP did mot match.!";
            return View();
        }

        public ActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResetPassword(IFormCollection fc)
        {
            string emailotp = _httpContextAccessor.HttpContext.Session.GetString("emailotp").ToString();
            var obj = dc.TblUsers.Where(u => u.Email == emailotp).FirstOrDefault();
            obj.Password = fc["pass"];
            //dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.TblUsers.Update(obj);
            dc.SaveChanges();

            return RedirectToAction("Login");
        }

        public static void SendEmail(string toEmail, string subject, string msgBody)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("r.k.rathod191@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = msgBody;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("r.k.rathod191@gmail.com", "tizcjcuzxrdwikcf");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

    }
}
