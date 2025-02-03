using Microsoft.AspNetCore.Identity;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using System.Numerics;

namespace PathFinder.Services.Data.Implementations
{
    public class JobService(
        IRepository<Job, int> jobRepository,
        UserManager<ApplicationUser> userManager) : IJobService
    {
        public async Task CreateJobOfferAsync(JobAddViewModel model)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            var job = new Job()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                JobType = Enum.Parse<JobType>(model.JobType),
                Location = model.Location,
                Position = model.Position,
                Requirement = model.Requirement,
                Salary = model.Salary,
            };

            await jobRepository.AddAsync(job);
        }

        public async Task<Job> EditJobInfoAsync(JobEditViewModel model, int id)
        {
            var job = await jobRepository.GetByIdAsync(id);

            if (job == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (job.IsDeleted)
            {
                throw new ArgumentException("Entity is already delted");
            }

            job.Title = model.Title;
            job.Description = model.Description;
            job.JobType = Enum.Parse<JobType>(model.JobType);
            job.Location = model.Location;
            job.Position = model.Position;
            job.Requirement = model.Requirement;
            job.Salary = model.Salary;

            await jobRepository.UpdateAsync(job);

            return job;
        }

        public async Task<JobEditViewModel> GetEditJobByIdAsync(int id)
        {
            var entity = await jobRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (entity.IsDeleted)
            {
                throw new ArgumentException("Entity already deleted");
            }

            var job = new JobEditViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                JobType = entity.JobType.ToString(),
                Location = entity.Location,
                Position = entity.Position,
                Requirement= entity.Requirement,
                Salary = entity.Salary
            };

            return job;
        }

        public async Task<JobDetailsViewModel> GetJobDetailsAsync(int id)
        {
            var entity = await jobRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (entity.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            var job = new JobDetailsViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description ?? string.Empty,
                JobType = entity.JobType.ToString(),
                Location = entity.Location,
                Postion = entity.Position,
                Requirement = entity.Requirement,
                Salary = entity.Salary,
                AverageStarRating= entity.AverageStarRating
            };

            return job;
        }

        public async Task<JobDeleteViewModel> GetDeleteJobAsync(int id, string userId)
        {
            var entity = await jobRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (entity.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new NullReferenceException("Invalid user id");
            }

            string username = $"{user.FirstName} {user.LastName}";

            var job = new JobDeleteViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                PublishedBy = username
            };

            return job;
        }

        public async Task DeleteJobAsync(JobDeleteViewModel model)
        {
            Job job = await jobRepository.GetByIdAsync(model.Id);

            if (job == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (job.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            if(!job.IsDeleted || job != null)
            {
                job.IsDeleted = true;

                await jobRepository.UpdateAsync(job);
            }
        }
    }
}
