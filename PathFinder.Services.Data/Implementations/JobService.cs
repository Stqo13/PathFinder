using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.JobViewModels;
using PathFinder.ViewModels.Review;
using static PathFinder.Common.ApplicationConstraints.ReviewConstraints;

namespace PathFinder.Services.Data.Implementations
{
    public class JobService(
        IRepository<Job, int> jobRepository,
        IRepository<JobSphere, object> jobSphereRepository,
        IRepository<Sphere, int> sphereRepository,
        IGoogleMapsService googleMapsService,
        UserManager<ApplicationUser> userManager) : IJobService
    {
        public async Task CreateJobOfferAsync(JobAddViewModel model, string userId)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            var job = new Job()
            {
                Title = model.Title,
                Description = model.Description,
                JobType = Enum.Parse<JobType>(model.JobType),
                Location = model.Location,
                Position = model.Position,
                Requirement = model.Requirement,
                Salary = model.Salary,
                CompanyId = userId
            };

            if (!string.IsNullOrEmpty(job.Location))
            {
                var coordinates = await googleMapsService.GetCoordinatesAsync(job.Location);
                if (coordinates != null)
                {
                    job.Coordinates = $"{coordinates.Value.Latitude},{coordinates.Value.Longitude}";
                }
            }

            await jobRepository.AddAsync(job);

            if (model.SphereIds != null && model.SphereIds.Any())
            {
                foreach (var sphereId in model.SphereIds)
                {
                    var jobSphere = new JobSphere()
                    {
                        JobId = job.Id,
                        SphereId = sphereId,
                    };

                    await jobSphereRepository.AddAsync(jobSphere);
                }
            }
        }

        private double ToRadians(double angle) => Math.PI * angle / 180.0;

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
                Location = entity.Location ?? string.Empty,
                Position = entity.Position,
                Requirement= entity.Requirement,
                Salary = entity.Salary
            };

            return job;
        }

        public async Task<JobDetailsViewModel> GetJobDetailsAsync(int id)
        {
            JobDetailsViewModel? job = await jobRepository
                .GetAllAttached()
                .Where(j => j.Id == id && j.IsDeleted == false)
                .Include(j => j.Reviews)
                .Select(j => new JobDetailsViewModel()
                {
                    Id = j.Id,
                    Title = j.Title,
                    JobType = j.JobType.ToString(),
                    Description = j.Description,
                    Position = j.Position,
                    Salary = j.Salary,
                    Location = j.Location ?? string.Empty,
                    Requirement = j.Requirement,
                    AverageStarRating = j.AverageStarRating,
                    Reviews = j.Reviews
                        .Select(r => new ReviewInfoViewModel
                        {
                            Id = r.Id,
                            StarRating = r.StarRating,
                            Comment = r.Comment,
                            ReviewDate = r.ReviewDate.ToString(ReviewDateDateTimeFormat),
                            Publisher = $"{r.Publisher.FirstName} {r.Publisher.LastName}"
                        })
                        .ToList(),
                })
                .FirstOrDefaultAsync();

            if (job == null)
            {
                throw new NullReferenceException("Entity not found");
            }

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

        public async Task<IEnumerable<JobInfoViewModel>> GetAllJobOffersAsync(
            int pageNumber = 1,
            int pageSize = 6,
            List<int>? sphereIds = null,
            string? searchKeyword = null,
            string? inputCoordinates = null)
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
                    .Select(x => x.Job)
                    .Distinct();
            }

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                jobs = jobs.Where(j => EF.Functions.Like(j.Title.ToLower(), $"%{searchKeyword.ToLower()}%"));
            }

            if (!string.IsNullOrEmpty(inputCoordinates))
            {
                var inputLatLng = inputCoordinates.Split(',');
                double inputLat = double.Parse(inputLatLng[0]);
                double inputLng = double.Parse(inputLatLng[1]);

                var jobCoordinates = await jobs
                    .Where(j => !string.IsNullOrEmpty(j.Coordinates))
                    .Select(j => new
                    {
                        j.Id,
                        Coordinates = j.Coordinates
                    })
                    .ToListAsync();

                var nearbyJobIds = jobCoordinates
                    .Select(j => new
                    {
                        j.Id,
                        Distance = CalculateHaversineDistance(inputLat, inputLng, j.Coordinates)
                    })
                    .Where(j => j.Distance <= 30) 
                    .OrderBy(j => j.Distance) 
                    .Take(5) 
                    .Select(j => j.Id)
                    .ToList();

                jobs = jobs.Where(j => nearbyJobIds.Contains(j.Id));
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
                    Position = j.Position,
                    Company = j.Company,
                    Spheres = j.JobsSpheres.Select(js => js.Sphere.Name).ToList()
                })
                .ToListAsync();

            return offers;
        }

        private double CalculateHaversineDistance(double inputLat, double inputLng, string jobCoordinates)
        {
            const double EarthRadiusKm = 6371.0;

            var jobLatLng = jobCoordinates.Split(',');
            double jobLat = double.Parse(jobLatLng[0]);
            double jobLng = double.Parse(jobLatLng[1]);

            double dLat = ToRadians(jobLat - inputLat);
            double dLon = ToRadians(jobLng - inputLng);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(inputLat)) * Math.Cos(ToRadians(jobLat)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm * c;
        }

        public async Task<int> GetTotalPagesAsync(
            int pageSize,
            List<int>? sphereIds = null,
            string? searchKeyword = null,
            string? inputCoordinates = null)
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

            if (!String.IsNullOrEmpty(searchKeyword))
            {
                jobs = jobs.Where(j => EF.Functions.Like(j.Title.ToLower(), $"%{searchKeyword.ToLower()}%"));
            }

            if (!string.IsNullOrEmpty(inputCoordinates))
            {
                var inputLatLng = inputCoordinates.Split(',');
                double inputLat = double.Parse(inputLatLng[0]);
                double inputLng = double.Parse(inputLatLng[1]);

                var jobCoordinates = await jobs
                    .Where(j => !string.IsNullOrEmpty(j.Coordinates))
                    .Select(j => new
                    {
                        j.Id,
                        Coordinates = j.Coordinates
                    })
                    .ToListAsync();

                var nearbyJobIds = jobCoordinates
                    .Select(j => new
                    {
                        j.Id,
                        Distance = CalculateHaversineDistance(inputLat, inputLng, j.Coordinates)
                    })
                    .Where(j => j.Distance <= 30)
                    .OrderBy(j => j.Distance) 
                    .Take(5)
                    .Select(j => j.Id)
                    .ToList();

                jobs = jobs.Where(j => nearbyJobIds.Contains(j.Id));
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
                    Salary = j.Salary,
                    Position = j.Position,
                    Company = j.Company
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
