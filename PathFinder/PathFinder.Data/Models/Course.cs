using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.CourseConstraints;


namespace PathFinder.Data.Models
{
    public class Course
    {
        [Comment("Course's identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Course's name")]
        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Course's mode(Online/In-person)")]
        public Mode Mode { get; set; }

        [Comment("Course's description")]
        [MaxLength(CourseDescriptionMaxLength)]
        public string? Description { get; set; }

        [Comment("Course's duration in minutes")]
        [Required]
        public int DurationInMinutes { get; set; }

        [Comment("Course's location")]
        [Required]
        [MaxLength(CourseLocationMaxLength)]
        public string Location { get; set; } = null!;

        [Comment("Couse's start date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Comment("Course's users")]
        public virtual ICollection<UserCourse> UsersCourses { get; set; }
            = new List<UserCourse>();

        [Comment("Course's spheres")]
        public virtual ICollection<CourseSphere> CoursesSpheres { get; set; }
            = new List<CourseSphere>();
    }
}
