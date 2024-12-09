using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class CourseOffer : Course
    {
        [Comment("Course's institution")]
        public string? Institution { get; set; }

        [Comment("Course's average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Course's monthly price")]
        [Required]
        public decimal MonthlyPrice { get; set; }

        [Comment("Course's reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();
    }
}
