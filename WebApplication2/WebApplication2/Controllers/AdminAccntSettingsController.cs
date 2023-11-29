using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminAccntSettingsController : Controller
    {
        public IActionResult ShowAccountSettings()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }

        public IActionResult ChangePassword() 
        {
            return View();
        }
    }
}
