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
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}/PathFinder.Data/Data/courses.json");

            var courses = JsonConvert.DeserializeObject<List<Course>>(json)
                ?? throw new Exception("Invalid json file path");

            return courses;
        }
    }
}
