using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;


namespace WebApplicationDemo.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult List()
        {
            ViewData["message"] = "Hello from controller";
            List<string> names = new List<string>() { "Amol", "Rohan", "Suraj" };
            ViewData["names"] = names;
            ViewBag.Names = names;
            List<Employeecs> employees = new List<Employeecs>() {
              new Employeecs{Id=1,Name="Amol",Department="Development",Salary=30000},
                new Employeecs{Id=2,Name="nmol",Department="itlopment",Salary=70000},
                new Employeecs{Id=3,Name="lmol",Department="cslopment",Salary=60000},
                new Employeecs{Id=4,Name="jmol",Department="mrcelopment",Salary=50000},
                new Employeecs{Id=5,Name="gmol",Department="cnlopment",Salary=20000},
                new Employeecs{Id=6,Name="mmol",Department="kjhlopment",Salary=40000},
            };
             ViewData["emplist"] =employees;
             ViewBag.Employess = employees;
            return View();


          }


            
        }
    }

