using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.JobConstraints;

namespace PathFinder.ViewModels.JobViewModels
{
    public class JobAddViewModel
    {
        [Required]
        public int Id { get; set; }

        [StringLength(JobTitleMaxLength, MinimumLength = JobTitleMinLength, ErrorMessage = "Job title must be between 2 and 80 characters!")]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(JobDescriptionMaxLength)]
        public string? Description { get; set; }


    }
}
