using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.CourseViewModels;
using System.Security.Claims;

namespace PathFinder.Controllers
{
    [Authorize]
    public class CourseController(
        ICourseService courseService,
        ILogger<CourseController> logger) : Controller
    {
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            try
            {
                int pageSize = 6;
                var offers = await courseService.GetAllCourseOffersAsync(pageNumber, pageSize);
                int totalPages = await courseService.GetTotalPagesAsync(pageSize);

                var model = new CourseIndexViewModel()
                {
                    CourseOffers = offers,
                    CurrentPage = pageNumber,
                    TotalPages = totalPages
                };

                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching job offers. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
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

                return RedirectToAction(nameof(Details));
            }
            catch (Exception ex)
            {

                logger.LogError($"An error occured while editing course offer. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var course = await courseService.GetJobDetailsAsync(id);

                return View(course);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching course offer details. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                string userId = GetCurrentClientId();

                var course = await courseService.GetDeleteCourseAsync(id, userId);

                return View(course);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching course offer delete info. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpPost]
        public async Task<IActionResult> Delete(CourseDeleteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); 
            }

            try
            {
                await courseService.DeleteCourseAsync(model);

                return RedirectToAction(nameof(Details));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while deleting course offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Institution")]
        [HttpGet]
        public async Task<IActionResult> MyOffers()
        {
            try
            {
                string userId = GetCurrentClientId();
                var models = await courseService.GetAllCourseOffersByUserIdAsync(userId);

                return View(models);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching personal course offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        private string GetCurrentClientId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }
    }
}
