

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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\userJobs.json";
            var json = File.ReadAllText(jsonFilePath);

            var userJobs = JsonConvert.DeserializeObject<List<UserJob>>(json)
                ?? throw new Exception("Invalid json file path");

            return userJobs;
        }
    }
}
