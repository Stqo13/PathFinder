using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using static PathFinder.Common.ApplicationConstraints.ReviewConstraints;

namespace PathFinder.Data.Models
{
    public class Review
    {
        [Comment("Review's idetifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Review's star rating")]
        public int? StarRating { get; set; }

        [Comment("Comment")]
        [MaxLength(ReviewCommentMaxLength)]
        public string? Comment { get; set; }

        [Comment("Review date")]
        [Required]
        public DateTime ReviewDate { get; set; }


        [Comment("Publisher foreign key")]
        public string PublisherId { get; set; } = null!;
        [ForeignKey(nameof(PublisherId))]
        [Comment("Publisher navigation property")]
        public virtual ApplicationUser Publisher { get; set; } = null!;

        [Comment("Job foreign key")]
        public int JobId { get; set; } 

        [ForeignKey(nameof(JobId))]
        [Comment("Job navigation property")]
        public virtual JobOffer Job { get; set; } = null!;

        [Comment("Course foreign key")]
        public int CourseId { get; set; } 

        [ForeignKey(nameof(CourseId))]
        [Comment("Course navigation property ")]
        public virtual CourseOffer Course { get; set; } = null!;
    }
}
