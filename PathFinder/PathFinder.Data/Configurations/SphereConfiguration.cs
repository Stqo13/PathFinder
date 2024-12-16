using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class SphereConfiguration
        : IEntityTypeConfiguration<Sphere>
    {
        public void Configure(EntityTypeBuilder<Sphere> builder)
        {
            builder.HasData();
        }

        public IEnumerable<Sphere> GenerateSpheres()
        {
            var spheres = new HashSet<Sphere> 
            { 
                new ()
                {
                    Id = 1,
                    Name = "Healthcare"
                },
                new ()
                {
                    Id = 2,
                    Name = "Technology"
                },
                new ()
                {
                    Id = 3,
                    Name = "Business & Finance"
                },
                new ()
                {
                    Id = 4,
                    Name = "Education"
                },
                new ()
                {
                    Id = 5,
                    Name = "Creative Arts"
                },
                new ()
                {
                    Id = 6,
                    Name = "Computer Science"
                },
                new ()
                {
                    Id = 7,
                    Name = "Graphic Design"
                },
                new ()
                {
                    Id = 8,
                    Name = "Marketing & Management"
                },
                new ()
                {
                    Id = 9,
                    Name = "Architecture"
                },
                new ()
                {
                    Id = 10,
                    Name = "Facility Management"
                },
                new ()
                {
                    Id = 11,
                    Name = "Education"
                },
                new ()
                {
                    Id = 12,
                    Name = "Engeneering"
                },
            };    
            
            return spheres;
        }
    }
}
