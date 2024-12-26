using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            var usersCourses = new HashSet<UserCourse>
            {
                new ()
                {
                    UserId = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                    CourseId = 5
                },
                new ()
                {
                    UserId = "9e547484-9ea8-45e6-a488-d657f6f1c598",
                    CourseId = 16
                }     
            };

            return usersCourses;
        }
    }
}
