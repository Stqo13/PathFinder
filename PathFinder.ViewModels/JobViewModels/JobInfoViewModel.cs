using PathFinder.Data.Models;

namespace PathFinder.ViewModels.JobViewModels
{
    public class JobInfoViewModel
    {
        public required int Id { get; set; }

        public required string Title { get; set; } = null!;

        public required string JobType { get; set; } = null!;

        public required decimal Salary { get; set; }

        public required string Position { get; set; } = null!;

        public required ApplicationUser Company { get; set; } = null!;

        public List<string> Spheres { get; set; } = new List<string>();
    }
}
