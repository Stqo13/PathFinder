using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using PathFinder.Services.Data.Implementations;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.CourseViewModels;

namespace PathFinder.Controllers
{
    [Authorize]
    public class CourseController(
        ICourseService courseService,
        ILogger<CourseController> logger) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var courseOffer = new CourseAddViewModel();

            return View(courseOffer);
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpPost]
        public async Task<IActionResult> Add(CourseAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await courseService.CreateCourseOfferAsync(model);

                return RedirectToAction(nameof(Add));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while adding course offer. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var course = await courseService.GetEditCourseById(id);
                return View(course);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching course offer info. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpPost]
        public async Task<IActionResult> Edit(CourseEditViewModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await courseService.EditCourseInfoAsync(model, id);

                return RedirectToAction(nameof(Edit));
            }
            catch (Exception ex)
            {

                logger.LogError($"An error occured while editing course offer. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                var course = await courseService.GetJobDetailsAsync(id);

                return View(course);
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }
}
