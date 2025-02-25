using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using static PathFinder.Common.Helpers.ControllerHelper;
using System.Security.Claims;
using PathFinder.Common.Helpers;

namespace PathFinder.Controllers
{
    [Authorize]    
    public class JobController(
        IJobService jobService,
        ILogger<JobController> logger): Controller
    {
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1, List<int>? selectedSpheres = null, string? searchKeyword = null)
        {
            try
            {
                int pageSize = 6;

                var offers = await jobService.GetAllJobOffersAsync(pageNumber, pageSize, selectedSpheres, searchKeyword);

                int totalPages = await jobService.GetTotalPagesAsync(pageSize, selectedSpheres, searchKeyword);

                var allSpheres = await jobService.GetAllSpheresAsync();

                var model = new JobIndexViewModel()
                {
                    JobOffers = offers,
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
                logger.LogError($"An error occurred while fetching job offers. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            var jobOffer = new JobAddViewModel();

            return View(jobOffer);
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpPost]
        public async Task<IActionResult> Add(JobAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await jobService.CreateJobOfferAsync(model);

                return RedirectToAction(nameof(Add));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while adding job offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var job = await jobService.GetJobDetailsAsync(id);

                return View(job);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching job offer details. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var job = await jobService.GetEditJobByIdAsync(id);

                return View(job);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching job offer edit info. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpPost]
        public async Task<IActionResult> Edit(JobEditViewModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await jobService.EditJobInfoAsync(model, id);

                return RedirectToAction(nameof(Details));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while editing job offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                string userId = ControllerHelper.GetCurrentClientId(User);

                var job = await jobService.GetDeleteJobAsync(id, userId);

                return View(job);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching job offer delete info. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpPost]
        public async Task<IActionResult> Delete(JobDeleteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await jobService.DeleteJobAsync(model);

                return RedirectToAction(nameof(Details));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while deleting job offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpGet]
        public async Task<IActionResult> MyOffers()
        {
            try
            {
                string userId = ControllerHelper.GetCurrentClientId(User);
                var models = await jobService.GetAllJobOffersByUserIdAsync(userId);

                return View(models);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching personal job offer. {ex.Message}");
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
