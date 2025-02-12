using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Comment("Course's lesson duration in minutes")]
        [Required]
        public int DurationInMinutes { get; set; }

        [Comment("Course's duration in weeks")]
        [Required]
        public int CourseDuration { get; set; }

        /// <summary>
        /// FORMAT "Country, City, Street"
        /// </summary>
        [Comment("Course's location")]
        [MaxLength(CourseLocationMaxLength)]
        public string? Location { get; set; }

        [Comment("Couse's start date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Comment("Couse's end date")]
        [Required]
        public DateTime EndDate { get; set; }

        [Comment("Institution's foreign key")]
        [Required]
        public string InstitutionId { get; set; } = null!;

        [Comment("Institution's navigation property")]
        [ForeignKey(nameof(InstitutionId))]
        public virtual ApplicationUser Institution { get; set; } = null!;

        [Comment("Course's average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Course's monthly price")]
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        [Comment("Course's reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
           = new List<Review>();

        [Comment("Course's users")]
        public virtual ICollection<UserCourse> UsersCourses { get; set; }
            = new List<UserCourse>();

        [Comment("Course's spheres")]
        public virtual ICollection<CourseSphere> CoursesSpheres { get; set; }
            = new List<CourseSphere>();
    }
}
