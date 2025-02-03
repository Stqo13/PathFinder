using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.JobConstraints;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    public class Job
    {
        [Comment("Job's idetifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Job's title")]
        [MaxLength(JobTitleMaxLength)]
        [Required]
        public string Title { get; set; } = null!;

        [Comment("Job's details")]
        [MaxLength(JobDescriptionMaxLength)]
        public string? Description { get; set; }

        [Comment("The type of the job")]
        [Required]
        public JobType JobType { get; set; }

        /// <summary>
        /// FORMAT "Country, City, Street"
        /// </summary>
        [Comment("Job's location")]
        [MaxLength(JobLocationMaxLength)]
        public string? Location { get; set; }

        [Comment("Company's foreign key")]
        [Required]
        public string CompanyId { get; set; } = null!;

        [Comment("Company's navigation property")]
        [ForeignKey(nameof(CompanyId))]
        public virtual ApplicationUser Company { get; set; } = null!;

        [Comment("Job's position")]
        [Required]
        [MaxLength(JobPositionMaxLength)]
        public string Position { get; set; } = null!;

        [Comment("Job's requiements")]
        [Required]
        public string Requirement { get; set; } = null!;

        [Comment("Job salary")]
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [Comment("Job average star rating")]
        public double? AverageStarRating { get; set; }

        //TODO: NEED TO CREATE MIGRATION(SOFT DELETE)
        public bool IsDeleted { get; set; }

        [Comment("Job reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();

        [Comment("User's jobs")]
        public virtual ICollection<UserJob> UsersJobs { get; set; }
            = new List<UserJob>();

        [Comment("Job's spheres")]
        public virtual ICollection<JobSphere> JobsSpheres { get; set; }
            = new List<JobSphere>();
    }

}
