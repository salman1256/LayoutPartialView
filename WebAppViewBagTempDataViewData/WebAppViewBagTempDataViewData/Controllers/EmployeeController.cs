using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppViewBagTempDataViewData.Models;

namespace WebAppViewBagTempDataViewData.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> listEmployees = new List<Employee>()
        {
            new Employee(){Id=1,Name="Sameer",Designation="Manager",Salary=98000.90,Doj=new DateTime(day:02,month:09,year:2019) },
            new Employee(){Id=2,Name="Nain",Designation="Developer",Salary=98000.90,Doj=new DateTime(day:21,month:03,year:2012) },
            new Employee(){Id=3,Name="Jai",Designation="Developer",Salary=78000.90,Doj=new DateTime(day:21,month:12,year:2012) },
            new Employee(){Id=4,Name="Vipin",Designation="Manager",Salary=78000.90,Doj=new DateTime(day:25,month:12,year:2012) },
            new Employee(){Id=5,Name="Sam",Designation="Developer",Salary=88000.90,Doj=new DateTime(day:21,month:08,year:2023) },
            new Employee(){Id=6,Name="Anu",Designation="HR",Salary=68000.90,Doj=new DateTime(day:26,month:09,year:2012) },
            new Employee(){Id=7,Name="Dinesh",Designation="Tester",Salary=75000.90,Doj=new DateTime(day:01,month:12,year:2021) },
            new Employee(){Id=8,Name="Kamal",Designation="Developer",Salary=83000.90,Doj=new DateTime(day:01,month:11,year:2020) },
        };

        [HttpGet]
       public ActionResult Create()
        {

            return View(new Employee());
        }
       
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
           if(ModelState.IsValid)
            {
                listEmployees.Add(emp); 
            }
            return RedirectToAction("Index");


        }
        public ActionResult Index()
        {
            ViewBag.msg = "Welcome to Employee";
            ViewBag.noEmp = listEmployees.Count;
            ViewData["message"] = "I am from View Data";
            return View(listEmployees);
        }
        public ActionResult TempDataEx()
        {
            Session["empCount"] = listEmployees.Count;
            TempData["empcount"] = listEmployees.Count;
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            return View();
                
        }
    }
}
