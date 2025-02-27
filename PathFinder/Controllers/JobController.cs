using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using static PathFinder.Common.Helpers.ControllerHelper;
using System.Security.Claims;
using PathFinder.Common.Helpers;
using System.Net;

namespace PathFinder.Controllers
{
    [Authorize]    
    public class JobController(
        IJobService jobService,
        IGoogleMapsService googleMapsService,
        ILogger<JobController> logger): Controller
    {
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1, List<int>? selectedSpheres = null, string? searchKeyword = null, string? address = null)
        {
            try
            {
                int pageSize = 6;

                string? inputCoordinates = null;

                if (!string.IsNullOrEmpty(address))
                {
                    var geocodingResult = await googleMapsService.GetCoordinatesAsync(address);
                    if (geocodingResult != null)
                    {
                        inputCoordinates = $"{geocodingResult.Value.Latitude},{geocodingResult.Value.Longitude}";
                    }
                }

                var offers = await jobService.GetAllJobOffersAsync(pageNumber, pageSize, selectedSpheres, searchKeyword, inputCoordinates);

                int totalPages = await jobService.GetTotalPagesAsync(pageSize, selectedSpheres, searchKeyword, inputCoordinates);

                var allSpheres = await jobService.GetAllSpheresAsync();

                var model = new JobIndexViewModel()
                {
                    JobOffers = offers,
                    CurrentPage = pageNumber,
                    TotalPages = totalPages,
                    SelectedSpheres = selectedSpheres ?? new List<int>(),
                    AvailableSpheres = allSpheres.ToList(),
                    SearchKeyword = searchKeyword ?? string.Empty,
                    Address = address ?? string.Empty
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
                string userId = GetCurrentClientId(User);
                
                await jobService.CreateJobOfferAsync(model, userId);

                return RedirectToAction(nameof(MyOffers));
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

                return RedirectToAction(nameof(MyOffers));
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

                return RedirectToAction(nameof(MyOffers));
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
