using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class JobOffer : Job
    {
        [Comment("Job's requiements")]
        [Required]
        public string Requirement { get; set; } = null!;

        [Comment("Job salary")]
        [Required]
        public decimal Salary { get; set; }

        [Comment("Job average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Job reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();


    }
}
