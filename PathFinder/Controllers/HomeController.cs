using Microsoft.AspNetCore.Mvc;
using PathFinder.ViewModels;
using PathFinder.ViewModels.AboutUsViewModels;
using System.Diagnostics;

namespace PathFinder.Controllers
{
    public class HomeController(
        ILogger<HomeController> logger
        ): Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutUsTedi()
        {
            var model = new FounderViewModel
            {
                Name = "Teodora Nedkova Nedkova",
                InstagramLink = "https://www.instagram.com/tedi_nedkova/",
                GitHubLink = "https://github.com/tedi-nedkova",
                FacebookLink = "https://www.facebook.com/profile.php?id=100048438143440",
                Avatar = "../images/profile-avatar-girl.jpg"
            };

            return RedirectToAction("AboutUs", "AboutUs", model);
        }

        [HttpPost]
        public IActionResult AboutUsStefan()
        {
            var model = new FounderViewModel
            {
                Name = "Stefan Milenov Dimitrov",
                InstagramLink = "https://www.instagram.com/_stefan_dw/",
                GitHubLink = "https://github.com/Stqo13",
                FacebookLink = "https://www.facebook.com/profile.php?id=100025660580060",
                Avatar = "../images/profile-avatar-boy.jpg"
            };

            return RedirectToAction("AboutUs", "AboutUs", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
