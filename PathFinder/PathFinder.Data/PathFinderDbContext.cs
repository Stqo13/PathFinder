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
