using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.JobConstraints;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Models
{
    public class Job
    {
        [Comment("Job's idetifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Job' title")]
        [Required]
        public Sphere Title { get; set; }

        [Comment("Job details")]
        [MaxLength(JobDescriptionMaxLength)]
        public string? Description { get; set; }

        [Comment("The type of the job")]
        [Required]
        public JobType JobType { get; set; }

        [Comment("Job location")]
        [Required]
        [MaxLength(JobLocationMaxLength)]
        public string Location { get; set; } = null!;

        [Comment("Company name")]
        [Required]
        [MaxLength(CompanyNameMaxLength)]
        public string CompanyName { get; set; } = null!;

        [Comment("Job position")]
        [Required]
        [MaxLength(JobPositionMaxLength)]
        public string Position { get; set; } = null!;

        public List<UserJob> UsersJobs { get; set; }
            = new List<UserJob>();
    }
}
