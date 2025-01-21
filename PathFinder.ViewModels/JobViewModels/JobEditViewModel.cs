using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.JobConstraints;

namespace PathFinder.ViewModels.JobViewModels
{
    public class JobEditViewModel
    {
        [Required]
        public int Id { get; set; }

        [StringLength(JobTitleMaxLength, MinimumLength = JobTitleMinLength, ErrorMessage = "Job title must be between 2 and 80 characters!")]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(JobDescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public string JobType { get; set; } = null!;

        [Required]
        [MaxLength(JobLocationMaxLength)]
        public string Location { get; set; } = null!;

        [Required]
        [MaxLength(JobPositionMaxLength)]
        public string Position { get; set; } = null!;

        [Required]
        public string Requirement { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
