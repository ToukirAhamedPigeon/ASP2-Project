using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class InitController : Controller
    {
        // GET: Init
        public ActionResult Index()
        {
            using (EmployeeContext db=new EmployeeContext())
            {
                db.Employees.Add(new Employee() {
                    Employee_Department = 1,
                    Employee_Name="Pigeon",
                    Employee_Salary="1000" 
                });
                db.SaveChanges();
            }
            return View();
        }
    }
}