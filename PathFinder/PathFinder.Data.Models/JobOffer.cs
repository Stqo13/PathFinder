using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PathFinder.Common.ApplicationConstraints.JobConstraints;

namespace PathFinder.Data.Models
{
    public class JobOffer
    {
        public int JobId { get; set; }

        [ForeignKey(nameof(JobId))]
        public virtual Job Job { get; set; } = null!;
        //[Comment("Job offer's idetifier")]
        //[Key]
        //public int Id { get; set; }

        //[Comment("Job title")]
        //[Required]
        //public Sphere Title { get; set; }

        //[Comment("Job details")]
        //[MaxLength(JobDescriptionMaxLength)]
        //public string? Description { get; set; }

        //[Comment("The type of the job(Online/In-person/Intership)")]
        //[Required]
        //public JobType JobType { get; set; }

        //[Comment("Job location")]
        //[Required]
        //[MaxLength(JobLocationMaxLength)]
        //public string Location { get; set; } = null!;

        //[Comment("Company name")]
        //[Required]
        //[MaxLength(CompanyNameMaxLength)]
        //public string CompanyName { get; set; } = null!;

        [Comment("Job's requiements")]
        [Required]
        public string Requirement { get; set; } = null!;

        //[Comment("Job position")]
        //[Required]
        //[MaxLength(JobPositionMaxLength)]
        //public string Position { get; set; } = null!;

        [Comment("Job salary")]
        [Required]
        public decimal Salary { get; set; }

        [Comment("Job average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Job reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();


        /// <summary>
        /// TODO Relationship between ApplicationUser and Job
        /// </summary>
    }
}
