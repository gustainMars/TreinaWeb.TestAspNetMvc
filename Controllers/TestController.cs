using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreinaWeb.TestAspNetMvc.Models;

namespace TreinaWeb.TestAspNetMvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            ViewBag.PersonDetail = person;
            return View("Greetings");
        }
    }
}
