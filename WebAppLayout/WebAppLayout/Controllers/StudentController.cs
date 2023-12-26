using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLayout.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult Display()
        {
            ViewBag.msg = "We can display students details from here.";
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.msg = "We can register Student from here.";
            return View();
        }
    }
}