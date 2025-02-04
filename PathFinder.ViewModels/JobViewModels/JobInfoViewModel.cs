namespace PathFinder.ViewModels.JobViewModels
{
    public class JobInfoViewModel
    {
        public required int Id { get; set; }

        public required string Title { get; set; } = null!;

        public required string JobType { get; set; } = null!;

        public required decimal Salary { get; set; }
    }
}
