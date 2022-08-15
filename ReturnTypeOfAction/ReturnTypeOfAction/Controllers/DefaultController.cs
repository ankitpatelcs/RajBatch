using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnTypeOfAction.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public DefaultController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public ContentResult Index()
        {
            return Content(_env.WebRootPath);
            //return Content("Learning .Net Core in TOPS.");
            //return Content("<div>Learning <b>.Net Core</b> in TOPS.</div>","text/html");
        }

        public ViewResult ShowMsg(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }

        public RedirectResult GotoURL()
        {
            // with HTTP status code : 302.
            return Redirect("http://www.google.com");
        }
        public RedirectResult GotoURLPermanently()
        {
            // with HTTP status code : 301.
            return RedirectPermanent("http://www.google.com");
        }

        public RedirectToActionResult GotoMsg()
        {
            return RedirectToAction("ShowMsg",new { msg="Happy independence day." });
        }

        public RedirectToRouteResult GotoAbout()
        {
            return RedirectToRoute("ShowMsg");
        }

        public FileResult DownloadFile()
        {
            return File("/css/site.css","text/html","ReturnFile.css");
        }
    }
}
