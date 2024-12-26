using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Configurations
{
    public class CourseConfiguration
        : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(this.GenerateCourses());
        }

        public IEnumerable<Course> GenerateCourses()
        {
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\courses.json";
            var json = File.ReadAllText(jsonFilePath);

            var courses = JsonConvert.DeserializeObject<List<Course>>(json)
                ?? throw new Exception("Invalid json file path");

            return courses;
        }
    }
}
