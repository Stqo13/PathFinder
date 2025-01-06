using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class UserCourseConfiguration
        : IEntityTypeConfiguration<UserCourse>
    {
        public void Configure(EntityTypeBuilder<UserCourse> builder)
        {
            builder.HasData(this.GenerateUsersCourses());
        }

        public IEnumerable<UserCourse> GenerateUsersCourses()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\userCourses.json");

            var usersCourses = JsonConvert.DeserializeObject<List<UserCourse>>(json)
                ?? throw new Exception("Invalid json file path");

            return usersCourses;
        }
    }
}
