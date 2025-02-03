namespace PathFinder.ViewModels.CourseViewModels
{
    public class CourseIndexViewModel
    {
        public IEnumerable<CourseInfoViewModel> CourseOffers { get; set; }
            = new List<CourseInfoViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
