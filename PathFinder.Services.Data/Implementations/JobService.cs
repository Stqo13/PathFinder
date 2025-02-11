using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;

namespace PathFinder.Services.Data.Implementations
{
    public class JobService(
        IRepository<Job, int> jobRepository,
        IRepository<JobSphere, object> jobSphereRepository,
        IRepository<Sphere, int> sphereRepository,
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
                Location = entity.Location ?? string.Empty,
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

        public async Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersAsync(int pageNumber, int pageSize, List<int>? sphereIds = null)
        {
            var query = jobSphereRepository.GetAllAttached();
            IQueryable<Job> jobs;

            if (sphereIds != null && sphereIds.Any())
            {
                jobs = query
                    .Where(js => sphereIds.Contains(js.SphereId))
                    .Include(js => js.Job)
                    .Select(x => x.Job)
                    .Distinct();
            }
            else
            {
                jobs = query
                    .Include(js => js.Job)
                    .Select(x => x.Job);
            }

            var offers = await jobs
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(j => new JobInfoViewModel
                {
                    Id = j.Id,
                    Title = j.Title,
                    JobType = j.JobType.ToString(),
                    Salary = j.Salary,
                    Spheres = j.JobsSpheres.Select(js => js.Sphere.Name).ToList()
                })
                .ToListAsync();

            return offers;
        }



        public async Task<int> GetTotalPagesAsync(int pageSize, List<int>? sphereIds = null)
        {
            var query = jobSphereRepository.GetAllAttached();

            IQueryable<Job> jobs;

            if (sphereIds != null && sphereIds.Any())
            {
                jobs = query
                    .Where(js => sphereIds.Contains(js.SphereId))
                    .Select(js => js.Job)
                    .Distinct();
            }
            else
            {
                jobs = query
                    .Select(js => js.Job)
                    .Distinct();
            }

            int totalJobs = await jobs.CountAsync();
            return (int)Math.Ceiling(totalJobs / (double)pageSize);
        }


        public async Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersByUserIdAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new NullReferenceException("User not found");
            }

            var offers = await jobRepository
                .GetAllAttached()
                .Where (j => j.IsDeleted == false && j.CompanyId == userId)
                .Select(j => new JobInfoViewModel 
                { 
                    Id =j.Id,
                    Title = j.Title,
                    JobType = j.JobType.ToString(),
                    Salary = j.Salary
                })
                .ToListAsync(); 

            return offers;
        }

        public async Task<IEnumerable<Sphere>> GetAllSpheresAsync()
        {
            var spheres = await sphereRepository
                .GetAllAsync();

            return spheres;
        }
    }
}
