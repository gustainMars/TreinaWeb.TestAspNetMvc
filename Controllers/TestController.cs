using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
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
            if (ModelState.IsValid)
            {
                person.Active = true;
                return View("Greetings", person);
            }
            else
                return View(person);
        }
    }
}
