using PathFinder.Data.Models;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Data.Repository;
using PathFinder.Services.Data.Implementations;
using PathFinder.Services.Data.Interfaces;

namespace PathFinder.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositories(
                this IServiceCollection services)
        {
            services.AddScoped<IRepository<Course, int>, Repository<Course, int>>();
            services.AddScoped<IRepository<CourseSphere, object>, Repository<CourseSphere, object>>();
            services.AddScoped<IRepository<Job, int>, Repository<Job, int>>();
            services.AddScoped<IRepository<JobSphere, object>, Repository<JobSphere, object>>();
            services.AddScoped<IRepository<Review, int>, Repository<Review, int>>();
            services.AddScoped<IRepository<Sphere, int>, Repository<Sphere, int>>();
            services.AddScoped<IRepository<UserCourse, object>, Repository<UserCourse, object>>();
            services.AddScoped<IRepository<UserJob, object>, Repository<UserJob, object>>();
            services.AddScoped<IRepository<UserSphere, object>, Repository<UserSphere, object>>();
            services.AddScoped<IRepository<ApplicationUser, string>, Repository<ApplicationUser, string>>();
            services.AddScoped<IRepository<CompanyRoleRequest, int>, Repository<CompanyRoleRequest, int>>();
            services.AddScoped<IRepository<InstitutionRoleRequest, int>, Repository<InstitutionRoleRequest, int>>();

            return services;
        }

        public static IServiceCollection RegisterUserDefinedServices(
            this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleRequestService, RoleRequestService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();

            return services;
        }
    }
}
