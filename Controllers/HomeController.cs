using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // Same as import in JS
using thomasSecondWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace thomasSecondWebApp.Controllers
{
    public class HomeController : Controller // This is going to inherit from the controller class
    {
        // GET: /<controller>/
        public IActionResult Index() //Index is the default view that it will return - This is going to be Razor pages
        {
            return View();
        }

        [HttpGet("GradeCalculator")] // This is a tag helper
        public IActionResult GradeCalculator ()
        {
            return View();
        }

        [HttpPost("GradeCalculator")]          // This is called the method signature
        public IActionResult GradeCalculator (GradeCalculatorModel model) // We just overloaded this method - called it the same thing, but gave it parameters to differentiate
        {
            return View();
        }
    }
}
