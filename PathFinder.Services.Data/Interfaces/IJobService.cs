using PathFinder.Data.Models;
using PathFinder.ViewModels.JobViewModels;

namespace PathFinder.Services.Data.Interfaces
{
    public interface IJobService
    {
        Task CreateJobOfferAsync(JobAddViewModel model);

        Task<JobDetailsViewModel> GetJobDetailsAsync(int id);

        Task<JobEditViewModel> GetEditJobByIdAsync(int id);

        Task<Job> EditJobInfoAsync(JobEditViewModel model, int id);

        Task<JobDeleteViewModel> GetDeleteJobAsync(int id, string userId);

        Task DeleteJobAsync(JobDeleteViewModel model);

        Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersAsync(int pageNumber, int pageSize);

        Task<int> GetTotalPagesAsync(int pageSize);
    }
}
