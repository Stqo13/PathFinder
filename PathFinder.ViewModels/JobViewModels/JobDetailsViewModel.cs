using PathFinder.ViewModels.Review;

namespace PathFinder.ViewModels.JobViewModels
{
    public class JobDetailsViewModel
    {
        public required int Id { get; set; }   

        public required string Title { get; set; }

        public required string? Description { get; set; }

        public required string JobType { get; set; }

        public required string Location { get; set; }

        public required string Position { get; set; }

        public required string Requirement { get; set; }

        public required decimal Salary { get; set; }

        public double? AverageStarRating { get; set; }

        public List<ReviewInfoViewModel> Reviews { get; set; }
           = new List<ReviewInfoViewModel>();
    }
}
