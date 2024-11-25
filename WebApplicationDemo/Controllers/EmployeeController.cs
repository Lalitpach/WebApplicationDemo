using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeDetails(User users)
        {
            return View();
        }

    }
}
