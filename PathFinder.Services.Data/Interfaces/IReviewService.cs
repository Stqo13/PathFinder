using PathFinder.ViewModels.ReviewViewModels;

namespace PathFinder.Services.Data.Interfaces
{
    public interface IReviewService
    {
        Task CreateReviewAsync(ReviewAddViewModel model, string userId);
    }
}
