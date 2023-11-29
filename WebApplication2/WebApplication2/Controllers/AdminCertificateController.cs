using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminCertificateController : Controller
    {
        public IActionResult ShowCertificates()
        {
            return View();
        }

        public IActionResult AddCertificates()
        {
            return View();
        }
    }
}
