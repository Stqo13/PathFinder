using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class CourseOffer : Course
    {
        [Comment("Course institution")]
        public string? Institution { get; set; }

        [Comment("Course average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Course monthly price")]
        [Required]
        public decimal MonthlyPrice { get; set; }

        [Comment("Course reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();
    }
}
