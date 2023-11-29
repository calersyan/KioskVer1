using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminPartnershipController : Controller
    {
        public IActionResult ShowPartnerships()
        {
            return View();
        }

        public IActionResult AddPartnerships()
        {
            return View();
        }
    }
}
