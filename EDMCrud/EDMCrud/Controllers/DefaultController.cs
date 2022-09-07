using EDMCrud.EDM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext _context = null;
        public DefaultController(CompanyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tblemployees.ToList());
        }
    }
}
