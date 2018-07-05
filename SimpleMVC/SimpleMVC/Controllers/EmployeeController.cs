using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class EmployeeController : Controller
    {
        MydbEntities1 db;
        public EmployeeController()
        {
            db = new MydbEntities1();
        }
        // GET: Employee 
        public ActionResult Index()
        {
            var employees = db.Employees;
            return View(employees);
        }

        public ActionResult Detail(int id)
        {
            var employee = db.Employees.Where(e => e.Id == id).FirstOrDefault();

            return View(employee);
        }
        public ActionResult Create()
        {
            Employee empToAdd = new Employee();

            return View(empToAdd);
        
        }
    }
}