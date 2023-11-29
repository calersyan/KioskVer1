using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminFacilityController : Controller
    {
        public IActionResult ShowFacilities()
        {
            return View();
        }

        public IActionResult AddFacilities()
        {
            return View();
        }

        public IActionResult EditFacilities() 
        {
            return View();
        }
    }
}
