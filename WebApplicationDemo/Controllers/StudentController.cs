using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class StudentController : Controller
    {
      
            public IActionResult StudentDetail()
            {
                List<string> branches = new List<string> { "IT", "Mechanical", "Civil", "Science", "Electronics" };
                ViewData["branches"] = new SelectList(branches);

                return View();
            }

            [HttpPost]
            public IActionResult StudentDetail(IFormCollection form)
            {
                ViewBag.Name = form["name"];
                ViewBag.RollNum = form["rollnum"];
                ViewBag.Branch = form["branch"];
                ViewBag.CurrentYear = form["currentyear"];

                return View("Display");
            }
        }
    }
        

    

