using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;

namespace PathFinder.Data
{
    public class PathFinderDbContext : IdentityDbContext<ApplicationUser>
    {
        public PathFinderDbContext()
        {
            
        }

        public PathFinderDbContext(DbContextOptions<PathFinderDbContext> options)
                :base(options) 
        {
            
        }

        public override DbSet<ApplicationUser> Users { get; set; } = null!;

        public virtual DbSet<Course> Courses { get; set; } = null!;

        public virtual DbSet<CourseOffer> CourseOffers { get; set; } = null!;

        public virtual DbSet<CourseSphere> CoursesSpheres { get; set; } = null!;

        public virtual DbSet<Job> Jobs { get; set; } = null!;

        public virtual DbSet<JobOffer> JobOffers { get; set; } = null!;

        public virtual DbSet<JobSphere> JobsSpheres { get; set; } = null!;

        public virtual DbSet<Review> Reviews { get; set; } = null!;

        public virtual DbSet<Sphere> Spheres { get; set; } = null!;

        public virtual DbSet<UserCourse> UsersCourses { get; set; } = null!;

        public virtual DbSet<UserJob> UsersJobs { get; set; } = null!;

        public virtual DbSet<UserSphere> UsersSpheres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
