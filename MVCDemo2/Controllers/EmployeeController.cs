using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo2.Models;

namespace MVCDemo2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            //Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            return View(employee);
        }
    }
}