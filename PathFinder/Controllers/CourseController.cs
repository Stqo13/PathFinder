using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Common.Helpers;
using PathFinder.Data.Models;
using PathFinder.Data.Repository.Interfaces;
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
        public async Task<IActionResult> Index(int pageNumber = 1, List<int>? selectedSpheres = null, string? searchKeyword = null)
        {
            try
            {
                int pageSize = 6;

                var offers = await courseService.GetAllCourseOffersAsync(pageNumber, pageSize, selectedSpheres, searchKeyword);

                int totalPages = await courseService.GetTotalPagesAsync(pageSize, selectedSpheres, searchKeyword);

                var allSpheres = await courseService.GetAllSpheresAsync();

                var model = new CourseIndexViewModel()
                {
                    CourseOffers = offers,
                    CurrentPage = pageNumber,
                    TotalPages = totalPages,
                    SelectedSpheres = selectedSpheres ?? new List<int>(),
                    AvailableSpheres = allSpheres.ToList(),
                    SearchKeyword = searchKeyword ?? string.Empty
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
        public async Task<IActionResult> Add()
        {
            var courseOffer = new CourseAddViewModel();

            ViewData["Spheres"] = await courseService.GetAllSpheresAsync();

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

            string userId = ControllerHelper.GetCurrentClientId(User);

            try
            {
                await courseService.CreateCourseOfferAsync(model, userId);

                return RedirectToAction(nameof(MyOffers));
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

                return RedirectToAction(nameof(MyOffers));
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
                string userId = ControllerHelper.GetCurrentClientId(User);

                var course = await courseService.GetCourseDetailsAsync(id, userId);

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
                string userId = ControllerHelper.GetCurrentClientId(User);

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

                return RedirectToAction(nameof(MyOffers));
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
                string userId = ControllerHelper.GetCurrentClientId(User);
                var models = await courseService.GetAllCourseOffersByUserIdAsync(userId);

                return View(models);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching personal course offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult LoadPopup()
        {
            string message = "This content is loaded from a partial view!";
            return PartialView("_PopupContent", message);
        }
    }
}
