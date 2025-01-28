using PathFinder.Data.Models;
using PathFinder.ViewModels.CourseViewModels;

namespace PathFinder.Services.Data.Interfaces
{
    public interface ICourseService
    {
        Task CreateCourseOfferAsync(CourseAddViewModel model);

        Task<CourseDetailsViewModel> GetJobDetailsAsync(int id);

        Task<CourseEditViewModel> GetEditCourseById(int id);

        Task<Course> EditCourseInfoAsync(CourseEditViewModel model, int id);

        Task<CourseDeleteViewModel> GetDeleteCourseAsync(int id, string userId);

        Task DeleteCourseAsync(CourseDeleteViewModel model);
    }
}
