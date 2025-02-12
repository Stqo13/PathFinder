using PathFinder.Data.Models;

namespace PathFinder.ViewModels.CourseViewModels
{
    public class CourseIndexViewModel
    {
        public IEnumerable<CourseInfoViewModel> CourseOffers { get; set; }
            = new List<CourseInfoViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public List<Sphere> AvailableSpheres { get; set; } = new List<Sphere>();

        public List<int> SelectedSpheres { get; set; } = new List<int>();
    }
}
