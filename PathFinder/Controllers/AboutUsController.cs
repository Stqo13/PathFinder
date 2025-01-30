using Microsoft.AspNetCore.Mvc;
using PathFinder.ViewModels.AboutUsViewModels;

namespace PathFinder.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutUs(FounderViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
