using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class UserFeedController : Controller
    {
        public IActionResult ShowFeed()
        {
            return View();
        }
    }
}
