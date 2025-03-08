using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using static PathFinder.Common.Helpers.ControllerHelper;
using PathFinder.Common.Helpers;
using System.Net;
using Minio;
using Minio.DataModel.Args;
using OpenAI_API;

namespace PathFinder.Controllers
{
    [Authorize]    
    public class JobController(
        IJobService jobService,
        IGoogleMapsService googleMapsService,
        ICVUploaderService cVUploaderService,
        IConfiguration configuration,
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occurred while fetching job offers. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var jobOffer = new JobAddViewModel()
            {
                AvailableSpheres = await jobService.GetAllSpheresAsync()
            };

            var apiKey = Environment.GetEnvironmentVariable("GMAPS_API_KEY");

            if (apiKey != null)
            {
                ViewData["GoogleMapsApiKey"] = apiKey;  
            }
            else
            {
                ViewData["GoogleMapsApiKey"] = configuration["GoogleMapsApiKey:ApiKey"];
            }

            return View(jobOffer);
        }

        [Authorize(Roles = "Admin, Company")]
        [HttpPost]
        public async Task<IActionResult> Add(JobAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.AvailableSpheres = await jobService.GetAllSpheresAsync();

                return View(model);
            }

            try
            {
                string userId = GetCurrentClientId(User);
                
                await jobService.CreateJobOfferAsync(model, userId);

                return RedirectToAction(nameof(MyOffers));
            }
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
                var apiKey = Environment.GetEnvironmentVariable("GMAPS_API_KEY");

                if (apiKey != null)
                {
                    ViewData["GoogleMapsApiKey"] = apiKey;
                }
                else
                {
                    ViewData["GoogleMapsApiKey"] = configuration["GoogleMapsApiKey:ApiKey"];
                }

                var job = await jobService.GetEditJobByIdAsync(id);

                return View(job);
            }
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching personal job offer. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Enroll(/*IFormFile file,*/ int jobId)
        {
            try
            {
                string userId = GetCurrentClientId(User);

                //string uuid = Guid.NewGuid().ToString();
                //string fileName = uuid + ".pdf";

                //await cVUploaderService.Run(file, fileName);

                bool isEnrolled = await jobService.IsUserEnrolled(userId, jobId);

                if (isEnrolled)
                {
                    TempData["EnrollmentStatus"] = "AlreadyEnrolled";
                }
                else
                {
                    await jobService.EnrollUserToJob(userId, /*fileName,*/ jobId);
                    TempData["EnrollmentStatus"] = "Success";
                }

                return RedirectToAction(nameof(Details), new { id = jobId });
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while uploading file. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        public async Task<IActionResult> ViewStatistics()
        {
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API");

            if (apiKey == null)
            {
                apiKey = configuration["API"];
            }

            var aPIAuthentication = new APIAuthentication(apiKey);
            var openAIAPI = new OpenAIAPI(aPIAuthentication);
            var conversation = openAIAPI.Chat.CreateConversation();
            conversation.AppendUserInput("Give me a list of the top 10 most searched job positions and their average salary, formatted as: '{nameOfJobPosition} {averageSalaryForThisJobPosition}' without anything but this top10 list");
            var response = await conversation.GetResponseFromChatbotAsync();
            if (!string.IsNullOrEmpty(response))
            {
                List<(string, double)> values = [];
                response.Split("\n").Select(x => x.Split(". ").Skip(1).First().Split(" $")).ToList().ForEach(x => {
                    values.Add((x[0], double.Parse(x[1])));
                });

                return View(values);
            }

            return RedirectToAction("Error", "Home");
        }

        [HttpGet]
        public IActionResult LoadPopup()
        {
            string message = "This content is loaded from a partial view!";
            return PartialView("_PopupContent", message);
        }
    }
}
