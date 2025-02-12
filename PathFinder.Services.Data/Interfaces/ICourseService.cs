using PathFinder.Data.Models;
using PathFinder.ViewModels.CourseViewModels;

namespace PathFinder.Services.Data.Interfaces
{
    public interface ICourseService
    {
        Task CreateCourseOfferAsync(CourseAddViewModel model, string userId);

        Task<CourseDetailsViewModel> GetJobDetailsAsync(int id);

        Task<CourseEditViewModel> GetEditCourseById(int id);

        Task<Course> EditCourseInfoAsync(CourseEditViewModel model, int id);

        Task<CourseDeleteViewModel> GetDeleteCourseAsync(int id, string userId);

        Task DeleteCourseAsync(CourseDeleteViewModel model);

        Task<IEnumerable<CourseInfoViewModel>> GetAllCourseOffersAsync(int pageNumber, int pageSize, List<int>? sphereIds = null);

        Task<int> GetTotalPagesAsync(int pageSize, List<int>? sphereIds = null);

        Task<IEnumerable<CourseInfoViewModel>> GetAllCourseOffersByUserIdAsync(string userId);
    }
}
