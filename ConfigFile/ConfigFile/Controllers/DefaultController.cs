using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigFile.Controllers
{
    public class DefaultController : Controller
    {
        public IConfiguration Configuration { get; }
        public DefaultController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        public IActionResult Index()
        {
            ViewBag.SMTPServer = Configuration["MyApplicationKeys:SMTPServer"];
            ViewBag.AzureSQLServerURL = Configuration["MyApplicationKeys:AzureSQLServerURL"];
            ViewBag.EmployeePhotoUploadPath = Configuration["MyApplicationKeys:EmployeePhotoUploadPath"];
            return View();
        }
    }
}
