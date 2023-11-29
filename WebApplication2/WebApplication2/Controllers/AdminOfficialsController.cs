using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminOfficialsController : Controller
    {
        public IActionResult ShowOfficials()
        {
            return View();
        }
        
        public IActionResult AddOfficials()
        {
            return View();
        }

        public IActionResult EditOfficials()
        {
            return View();
        }

        
    }
}
