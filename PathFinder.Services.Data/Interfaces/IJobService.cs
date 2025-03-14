﻿using PathFinder.Data.Models;
using PathFinder.ViewModels.JobViewModels;

namespace PathFinder.Services.Data.Interfaces
{
    public interface IJobService
    {
        Task CreateJobOfferAsync(JobAddViewModel model, string userId);

        Task<JobDetailsViewModel> GetJobDetailsAsync(int id);

        Task<JobEditViewModel> GetEditJobByIdAsync(int id);

        Task<Job> EditJobInfoAsync(JobEditViewModel model, int id);

        Task<JobDeleteViewModel> GetDeleteJobAsync(int id, string userId);

        Task DeleteJobAsync(JobDeleteViewModel model);

        Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersAsync(int pageNumber, int pageSize, List<int>? sphereIds = null, string? searchKeyword = null, string? inputCoordinates = null);

        Task<int> GetTotalPagesAsync(int pageSize, List<int>? sphereIds = null, string? searchKeyword = null, string? inputCoordinates = null);

        Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersByUserIdAsync(string userId);

        Task<IEnumerable<Sphere>> GetAllSpheresAsync();

        Task EnrollUserToJob(string userId, /*string fileName,*/ int jobId);

        Task<bool> IsUserEnrolled(string userId, int jobId);
    }
}
