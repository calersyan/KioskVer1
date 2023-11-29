using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminBasicController : Controller
    {
        public IActionResult ShowBasicDetails()
        {
            return View();
        }

        public IActionResult EditDescription()
        {
            return View();
        }

        public IActionResult EditAddress()
        {
            return View();
        }

        public IActionResult EditVision()
        {
            return View();
        }

        public IActionResult EditMission()
        {
            return View();
        }

        public IActionResult EditHymn()
        {
            return View();
        }
    }
}
