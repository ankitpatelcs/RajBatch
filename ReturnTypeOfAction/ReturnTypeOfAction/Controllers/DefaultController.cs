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
    }
}
