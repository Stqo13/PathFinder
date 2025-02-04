using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using PathFinder.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.CourseConstraints;

namespace PathFinder.ViewModels.CourseViewModels
{
    public class CourseAddViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength, ErrorMessage = "Course name must be between 4 and 70 characters!")]
        public string Name { get; set; } = null!;

        [Required]
        public Mode Mode { get; set; }

        [StringLength(CourseDescriptionMaxLength, ErrorMessage = "Description must not exceed 800 characters!")]
        public string? Description { get; set; }

        [Required]
        public int DurationInMinutes { get; set; }

        [StringLength(CourseLocationMaxLength, MinimumLength = CourseLocationMinLength, ErrorMessage = "Location must be between 20 and 100 characters!")]
        public string? Location { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int CourseDuration {  get; set; }

        public double? AverageStarRating { get; set; }

        [Required]
        public decimal MonthlyPrice { get; set; }
    }
}
