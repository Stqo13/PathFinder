using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PathFinder.Data.Configurations
{
    public class RoleConfiguration
        : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(this.GenerateRoles());
        }

        public IEnumerable<IdentityRole> GenerateRoles()
        {
            var roles = new HashSet<IdentityRole>
            {
                new ()
                {
                    Id = "a94e9744-895c-4cd0-a450-fb2ca5ea73dc",
                    Name = "Admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = "ADMIN"
                },
                new ()
                {
                    Id = "cbd2b782-e4e3-4f79-84aa-5685d13320cb",
                    Name = "PFUser",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = "PFUSER"
                },
                new ()
                {
                    Id = "b69f39cc-e6e4-4394-b488-0d24c1d546ff",
                    Name = "Company",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = "COMPANY"
                },
                new ()
                {
                    Id = "be759a02-939c-4bb6-9063-f25e020d8a56",
                    Name = "Institution",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = "INSTITUTION"
                }
            };

            return roles;
        }
    }
}
