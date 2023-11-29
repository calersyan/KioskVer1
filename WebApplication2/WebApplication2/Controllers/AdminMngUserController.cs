using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminMngUserController : Controller
    {
        public IActionResult ShowUsers()
        {
            return View();
        }

        public IActionResult EditUsers()
        {
            return View();
        }

        public IActionResult ChangePassword() 
        {
            return View();
        }

        public IActionResult EditAdmin()
        {
            return View();
        }

        public IActionResult AddUserAccount() 
        {
            return View();
        }

        public IActionResult AddAdminAccount()
        {
            return View();
        }
    }
}
