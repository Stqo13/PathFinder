

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class UserJobConfiguration
        : IEntityTypeConfiguration<UserJob>
    {
        public void Configure(EntityTypeBuilder<UserJob> builder)
        {
            builder.HasData(this.GenerateUsersJobs());
        }

        public IEnumerable<UserJob> GenerateUsersJobs()
        {
            var usersJobs = new HashSet<UserJob>
            {
                new ()
                {
                    UserId = "e8d223af-7285-41c5-8c38-9e6989d4410d",
                    JobId = 1
                },
                new ()
                {
                    UserId = "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                    JobId = 2
                }
            };

            return usersJobs;
        }
    }
}
