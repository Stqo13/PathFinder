

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
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
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\userJobs.json");

            var usersJobs = JsonConvert.DeserializeObject<List<UserJob>>(json)
                ?? throw new Exception("Invalid json file path");

            return usersJobs;
        }
    }
}
