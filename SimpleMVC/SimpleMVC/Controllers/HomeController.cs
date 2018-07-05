using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //MydbEntities1 db = new MydbEntities1();
            //var employees = db.Employees;
            return View();
        }
    }
}