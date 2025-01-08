using Microsoft.AspNetCore.Mvc;

namespace PathFinder.Controllers
{
    public class RoleRequestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
