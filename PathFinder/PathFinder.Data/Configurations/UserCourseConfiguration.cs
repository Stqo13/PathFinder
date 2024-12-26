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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\userCourses.json";
            var json = File.ReadAllText(jsonFilePath);

            var userCourses = JsonConvert.DeserializeObject<List<UserCourse>>(json)
                ?? throw new Exception("Invalid json file path");

            return userCourses;
        }
    }
}
