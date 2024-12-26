using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class JobSphereConfiguration
        : IEntityTypeConfiguration<JobSphere>
    {
        public void Configure(EntityTypeBuilder<JobSphere> builder)
        {
            builder.HasData(this.GenerateJobsSpheres());
        }

        public IEnumerable<JobSphere> GenerateJobsSpheres()
        {
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\jobSpheres.json";
            var json = File.ReadAllText(jsonFilePath);

            var jobSpheres = JsonConvert.DeserializeObject<List<JobSphere>>(json)
                ?? throw new Exception("Invalid json file path");

            return jobSpheres;
        }
    }
}
