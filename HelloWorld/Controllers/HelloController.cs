using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello World!";
            ViewData["Now"] = DateTime.Now;
            return View();
        }
    }
}
