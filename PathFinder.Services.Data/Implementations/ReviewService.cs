using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.ReviewViewModels;
using static PathFinder.Common.ApplicationConstraints.ReviewConstraints;

namespace PathFinder.Services.Data.Implementations
{
    public class ReviewService(
        IRepository<Review, int> reviewRepository,
        UserManager<ApplicationUser> userManager) : IReviewService
    {
        public async Task CreateReviewAsync(ReviewAddViewModel model,string userId)
        {
            ApplicationUser? user = await userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new NullReferenceException("Invalid user id");
            }

            if (model == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            var review = new Review()
            {
                Comment = model.Comment,
                ReviewDate = model.ReviewDate,
                PublisherId = model.PublisherId,
                StarRating = model.StarRating,
                JobId = model.JobId,
                CourseId = model.CourseId
            };

            await reviewRepository.AddAsync(review);

            user.Reviews.Add(review);
        }
    }
}
