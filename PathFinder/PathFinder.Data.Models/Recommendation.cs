using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Models
{
    public class Recommendation
    {
        //RecommendationID: Unique identifier.
        [Comment("Recommendation identifier")]
        [Key]
        public int Id { get; set; }

        //UserID: Associated user ID.
        [Comment("User foreign key")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("User navigation property")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser Reciever { get; set; } = null!;
        //ItemID: Associated course or job.
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public CourseOffer? Course { get; set; }

        public int JobId { get; set; }

        [ForeignKey(nameof(JobId))]
        public JobOffer? Job { get; set; }
        //GeneratedOn: Date of recommendation generation.
        [Comment("The date of the suggestion being generated")]
        [Required]
        public DateTime SuggestedOn { get; set; }

        ///RelevanceScore: AI-calculated relevance.

        //Mode: Online or in-person recommendation.
        [Comment("Course/Job mode(Online/In-person)")]
        public Mode Mode { get; set; }
        //Location: In-person location (for courses/jobs).
        [Comment("Recommendation info: Institution location")]
        [Required]
        public string Location { get; set; } = null!;

        //Category: Career field(IT, Arts, etc.).
        [Comment("Interest foreign key")]
        public int InterestId { get; set; }

        [Comment("Interest navigation property")]
        [ForeignKey(nameof(InterestId))]
        public Interest Interest { get; set; } = null!;

        /// <summary>
        /// Using DTOs it will be decided what the recommendation is about
        /// </summary>
        //CostRange: Range for course/job cost.
        [Comment("Recommendation info: Job salary")]
        [Required]
        public decimal Salary { get; set; }

        [Comment("Recommendation info: Coures price")]
        [Required]
        public decimal CoursePrice { get; set; }
    }
}
