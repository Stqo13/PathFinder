using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    internal class JobConfiguration
        : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(this.GenerateJobs());
        }

        public IEnumerable<Job> GenerateJobs()
        {
            var jobs = new HashSet<Job>
            {
                new()
                {

                },
                new()
                {

                },
                new ()
                {

                },
                new ()
                {

                }
            };

            return jobs;
        }
    }
}
