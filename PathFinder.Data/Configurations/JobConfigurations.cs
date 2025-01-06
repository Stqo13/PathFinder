using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Configurations
{
    public class JobConfigurations
        : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(this.GenerateJob());
        }

        public IEnumerable<Job> GenerateJob()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\jobs.json");

            var jobs = JsonConvert.DeserializeObject<List<Job>>(json)
                ?? throw new Exception("Invalid json file path");

            return jobs;
        }
    }
}
