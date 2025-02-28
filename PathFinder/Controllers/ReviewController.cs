using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Common.Helpers;
using PathFinder.Data.Models;
using PathFinder.Services.Data.Implementations;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.ReviewViewModels;

namespace PathFinder.Controllers
{
    public class ReviewController(
        IReviewService reviewService,
        ILogger<ReviewController> logger): Controller
    {
        [HttpGet]
        public async Task<IActionResult> Add(int? jobId, int? courseId)
        {
            var review = new ReviewAddViewModel();
            if (jobId.HasValue)
            {
                review.JobId = jobId.Value;
            }
            else if (courseId.HasValue)
            {
                review.CourseId = courseId.Value;
            }

            review.PublisherId = ControllerHelper.GetCurrentClientId(User);

            return PartialView("_AddReviewPartial", review);

        }

        [HttpPost]
        public async Task<IActionResult> Add(ReviewAddViewModel model, int? jobId, int? courseId)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = ControllerHelper.GetCurrentClientId(User);

            try
            {
                await reviewService.CreateReviewAsync(model, userId);

                if (jobId.HasValue)
                {
                    return RedirectToAction("Details", "Job", new { Id = jobId});
                }

                return RedirectToAction("Details", "Course", new { Id = courseId});
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
                logger.LogError($"An error occured while adding a review. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }
    }
}
