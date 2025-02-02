using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using System.Security.Claims;

namespace PathFinder.Controllers
{
    [Authorize]    
    public class JobController(
        IJobService jobService,
        ILogger<JobController> logger): Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
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
                string userId = GetCurrentClientId();

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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> DisplayShowcase()
        {
            try
            {


                return View();
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching job offers. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        private string GetCurrentClientId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }
    }
}
