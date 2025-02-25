using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.Common.Helpers;
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
        public async Task<IActionResult> Add(ReviewAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = ControllerHelper.GetCurrentClientId(User);

            try
            {
                await reviewService.CreateReviewAsync(model, userId);

                return RedirectToAction(nameof(Add));
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while adding a review. {ex.Message}");

                return RedirectToAction("Error", "Home");
            }
        }
    }
}
