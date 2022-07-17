using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World!");
        }
    }
}
