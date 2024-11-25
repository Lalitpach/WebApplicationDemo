using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class PersonController : Controller
    {
        //[HttpGet]
        public IActionResult PersonalDetail()
        {
            List<string> cities = new List<string>() { "pune", "Mumbai", "Delhi", "surat" };
            ViewData["cities"] = new SelectList(cities);

            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetail(IFormCollection form)
        {
            ViewBag.Name = form["personname"];
            ViewBag.Name = form["email"];
            ViewBag.Name = form["cities"];
            return View("Display");



        }

    }
}
