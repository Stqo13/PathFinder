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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\courseSpheres.json";
            var json = File.ReadAllText(jsonFilePath);

            var courseSpheres = JsonConvert.DeserializeObject<List<CourseSphere>>(json)
                ?? throw new Exception("Invalid json file path");

            return courseSpheres;
        }
    }
}
