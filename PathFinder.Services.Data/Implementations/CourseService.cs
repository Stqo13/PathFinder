using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.CourseViewModels;
using static PathFinder.Common.ApplicationConstraints.CourseConstraints;

namespace PathFinder.Services.Data.Implementations
{
    public class CourseService(
        IRepository<Course, int> courseRepository,
        IRepository<CourseSphere, object> courseSphereRepository,
        IRepository<Sphere, int> sphereRepository,
        UserManager<ApplicationUser> userManager) : ICourseService
    {
        public async Task CreateCourseOfferAsync(CourseAddViewModel model, string userId)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            var course = new Course()
            {
                Name = model.Name,
                Mode = model.Mode,
                Description = model.Description,
                CourseDuration = model.CourseDuration ?? 1,
                DurationInMinutes = model.DurationInMinutes ?? 1,
                Location = model.Location,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                AverageStarRating = model.AverageStarRating,
                Price = model.Price ?? 1,
                InstitutionId = userId
            };

            await courseRepository.AddAsync(course);
        }

        public async Task DeleteCourseAsync(CourseDeleteViewModel model)
        {
            Course course = await courseRepository.GetByIdAsync(model.Id);

            if (course == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (course.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            if (!course.IsDeleted || course != null)
            {
                course.IsDeleted = true;

                await courseRepository.UpdateAsync(course);
            }
        }

        public async Task<Course> EditCourseInfoAsync(CourseEditViewModel model, int id)
        {
            var course = await courseRepository.GetByIdAsync(id);

            if (course == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (course.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            course.Name = model.Name;
            course.Mode = model.Mode;
            course.Description = model.Description;
            course.DurationInMinutes = model.DurationInMinutes;
            course.Location = model.Location;
            course.StartDate = model.StartDate;
            course.AverageStarRating = model.AverageStarRating;
            course.Price = model.Price;

            await courseRepository.UpdateAsync(course);
            
            return course;
        }

        public async Task<CourseDeleteViewModel> GetDeleteCourseAsync(int id, string userId)
        {
           var entity = await courseRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (entity.IsDeleted)
            {
                throw new NullReferenceException("Entity is already deleted");
            }

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new NullReferenceException("Invalid user id");
            }

            string username = $"{user.FirstName} {user.LastName}";

            var course = new CourseDeleteViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                PublishedBy = username
            };

            return course;
        }

        public async Task<CourseEditViewModel> GetEditCourseById(int id)
        {
            var entity = await courseRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            if (entity.IsDeleted)
            {
                throw new ArgumentException("Entity already deleted");
            }

            var course = new CourseEditViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Mode = entity.Mode,
                Description = entity.Description,
                DurationInMinutes = entity.DurationInMinutes,
                Location = entity.Location,
                StartDate = entity.StartDate,
                AverageStarRating = entity.AverageStarRating,
                Price = entity.Price,
            };

            return course;
        }

        public async Task<CourseDetailsViewModel> GetJobDetailsAsync(int id)
        {
           var entity  = await courseRepository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Enttity not found");
            }

            if (entity.IsDeleted)
            {
                throw new ArgumentException("Entity is already deleted");
            }

            var course = new CourseDetailsViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Mode = entity.Mode,
                Description = entity.Description,
                DurationInMinutes = entity.DurationInMinutes,
                CourseDuration = entity.CourseDuration,
                Location = entity.Location,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                AverageStarRating = entity.AverageStarRating,
                Reviews = entity.Reviews.ToList(),
                Price = entity.Price,
            };

            return course;
        }

        public async Task<IEnumerable<CourseInfoViewModel>> GetAllCourseOffersAsync(int pageNumber, int pageSize, List<int>? sphereIds = null, string? searchKeyword = null)
        {
            var query = courseSphereRepository.GetAllAttached();
            IQueryable<Course> courses;

            if (sphereIds != null && sphereIds.Any())
            {
                courses = query
                    .Where(js => sphereIds.Contains(js.SphereId))
                    .Include(js => js.Course)
                    .Select(x => x.Course)
                    .Distinct();
            }
            else
            {
                courses = query
                    .Include(js => js.Course)
                    .Select(x => x.Course)
                    .Distinct();
            }

            if (!String.IsNullOrEmpty(searchKeyword))
            {
                courses = courses.Where(c => EF.Functions.Like(c.Name.ToLower(), $"%{searchKeyword.ToLower()}%"));
            }

            var offers = await courses
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new CourseInfoViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Mode = c.Mode.ToString(),
                    StartDate = c.StartDate.ToString(StartDateDateTimeFormat),
                    EndDate = c.EndDate.ToString(EndDateDateTimeFormat),
                    Price = c.Price,
                    CourseDurationInWeeks = c.CourseDuration,
                    Spheres = c.CoursesSpheres.Select(cs => cs.Sphere.Name).ToList()
                })
                .ToListAsync();

            return offers;
        }

        public async Task<int> GetTotalPagesAsync(int pageSize, List<int>? sphereIds = null, string? searchKeyword = null)
        {
            var query = courseSphereRepository.GetAllAttached();

            IQueryable<Course> courses;

            if (sphereIds != null && sphereIds.Any())
            {
                courses = query
                    .Where(cs => sphereIds.Contains(cs.SphereId))
                    .Select(cs => cs.Course)
                    .Distinct();
            }
            else
            {
                courses = query
                    .Select(js => js.Course)
                    .Distinct();
            }

            if (!String.IsNullOrEmpty(searchKeyword))
            {
                courses = courses.Where(c => EF.Functions.Like(c.Name.ToLower(), $"%{searchKeyword.ToLower()}%"));
            }

            int totalCourses = await courses.CountAsync();
            return (int)Math.Ceiling(totalCourses / (double)pageSize);
        }

        public async Task<IEnumerable<CourseInfoViewModel>> GetAllCourseOffersByUserIdAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new NullReferenceException("User not found");
            }

            var offers = await courseRepository
                .GetAllAttached()
                .Where (c => c.IsDeleted == false && c.InstitutionId == userId)
                .Select(c => new CourseInfoViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    StartDate = c.StartDate.ToString(StartDateDateTimeFormat),
                    EndDate = c.EndDate.ToString(EndDateDateTimeFormat),
                    Price = c.Price,
                    Mode = c.Mode.ToString(),
                    CourseDurationInWeeks = c.CourseDuration
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
