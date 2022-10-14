using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentDemo.EDM;
using ViewComponentDemo.Models;

namespace ViewComponentDemo.Components
{
    public class EmployeeSummary : ViewComponent
    {
        private CompanyContext dc = null;
        public EmployeeSummary(CompanyContext _dc)
        {
            dc = _dc;
        }
        //public string Invoke()
        //{
        //    return $"Employee Count: {dc.Tblemployees.Count()}, Total Salary: {dc.Tblemployees.Sum(s => s.Salary)}";
        //}
        public IViewComponentResult Invoke(int salary)
        {
            return View(new EmployeeViewModel
            {
                EmployeeCount = dc.Tblemployees.Where(x => x.Salary == salary).Count(),
                TotalSalary = dc.Tblemployees.Where(x => x.Salary == salary).Sum(s => s.Salary)
            });
        }
    }
}
