namespace PathFinder.ViewModels.CourseViewModels
{
    public class CourseInfoViewModel
    {
        public required int Id { get; set; }

        public required string Name { get; set; } = null!;

        public required string Mode { get; set; } = null!;

        public required string StartDate { get; set; } = null!;

        public required string EndDate { get; set; } = null!;

        public required int CourseDurationInWeeks { get; set; }

        public required decimal Price { get; set; }
    }
}
