using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee= employeeContext.Employees.Single(emp => emp.Id == id);
            return View(employee);
        }
    }
}