using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using System.Reflection;

namespace PathFinder.Data
{
    public class PathFinderDbContext 
        : IdentityDbContext<ApplicationUser>
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

        public virtual DbSet<CourseSphere> CoursesSpheres { get; set; } = null!;

        public virtual DbSet<Job> Jobs { get; set; } = null!;

        public virtual DbSet<JobSphere> JobsSpheres { get; set; } = null!;

        public virtual DbSet<Review> Reviews { get; set; } = null!;

        public virtual DbSet<Sphere> Spheres { get; set; } = null!;

        public virtual DbSet<UserCourse> UsersCourses { get; set; } = null!;

        public virtual DbSet<UserJob> UsersJobs { get; set; } = null!;

        public virtual DbSet<UserSphere> UsersSpheres { get; set; } = null!;

        public virtual DbSet<CompanyRoleRequest> CompanyRoleRequests { get; set; } = null!;

        public virtual DbSet<InstitutionRoleRequest> InstitutionRoleRequests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=DESKTOP-6VQ6QDR\\SQLEXPRESS;Database=PathFinder;Integrated Security=true;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region CourseSphere Delete Behavior
            builder.Entity<CourseSphere>()
                .HasOne(cs => cs.Course)
                .WithMany()
                .HasForeignKey(cs => cs.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<CourseSphere>()
                .HasOne(cs => cs.Sphere)
                .WithMany()
                .HasForeignKey(cs => cs.SphereId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region JobSphere Delete Behavior
            builder.Entity<JobSphere>()
                .HasOne(js => js.Job)
                .WithMany()
                .HasForeignKey(js => js.JobId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<JobSphere>()
                .HasOne(js => js.Sphere)
                .WithMany()
                .HasForeignKey(js => js.SphereId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region UserCourse Delete Behavior
            builder.Entity<UserCourse>()
                .HasOne(uc => uc.User)
                .WithMany()
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<UserCourse>()
                .HasOne(uc => uc.Course)
                .WithMany()
                .HasForeignKey(uc => uc.CourseId)
                .OnDelete(DeleteBehavior.ClientCascade);
            #endregion

            #region UserJob Delete Behavior
            builder.Entity<UserJob>()
                .HasOne(uj => uj.User)
                .WithMany()
                .HasForeignKey(uj => uj.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<UserJob>()
                .HasOne(uj => uj.Job)
                .WithMany()
                .HasForeignKey(uj => uj.JobId)
                .OnDelete(DeleteBehavior.ClientCascade);
            #endregion

            #region UserSphere Delete Behavior
            builder.Entity<UserSphere>()
                .HasOne(us => us.User)
                .WithMany()
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<UserSphere>()
                .HasOne(us => us.Sphere)
                .WithMany()
                .HasForeignKey(us => us.SphereId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
