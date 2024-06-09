using Microsoft.AspNetCore.Mvc;

namespace HtmlPageApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RunFunction()
        {
            // This is where your C# function logic goes.
            string result = "C# function has been run!";
            return Content(result);
        }
    }
}
