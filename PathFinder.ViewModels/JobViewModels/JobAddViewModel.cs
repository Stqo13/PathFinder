using PathFinder.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        public string JobType { get; set; } = null!;

        [StringLength(JobLocationMaxLength, MinimumLength = JobLocationMinLength, ErrorMessage = "Location must be between 5 and 100 characters!")]
        public string? Location { get; set; }

        [Required]
        [MaxLength(JobPositionMaxLength)]
        public string Position { get; set; } = null!;

        [Required]
        public string Requirement { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        public IEnumerable<Sphere> AvailableSpheres { get; set; } = new List<Sphere>(); 
        public List<int> SelectedSpheres { get; set; } = new List<int>();
    }
}
