
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.CourseConstraints;


namespace PathFinder.Data.Models
{
    public class Course
    {
        [Comment("Course's idetifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Course's name")]
        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Course mode(Online/In-person)")]
        public Mode Mode { get; set; }

        [Comment("Course description")]
        [MaxLength(CourseDescriptionMaxLength)]
        public string? Description { get; set; }

        [Comment("Course duration in minutes")]
        [Required]
        public int DurationInMinutes { get; set; }

        [Comment("Course location")]
        [Required]
        [MaxLength(CourseLocationMaxLength)]
        public string Location { get; set; } = null!;

        [Comment("Start date")]
        [Required]
        public DateTime StartDate { get; set; }

        public ICollection<UserCourse> UsersCourses { get; set; }
            = new List<UserCourse>();
    }
}
