using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class CourseSphereConfiguration
        : IEntityTypeConfiguration<CourseSphere>
    {
        public void Configure(EntityTypeBuilder<CourseSphere> builder)
        {
            builder.HasData(this.GenerateCoursesSpheres());
        }

        public IEnumerable<CourseSphere> GenerateCoursesSpheres()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\courseSpheres.json");

            var coursesSpheres = JsonConvert.DeserializeObject<List<CourseSphere>>(json)
                ?? throw new Exception("Invalid json file path");

            return coursesSpheres;
        }
    }
}
