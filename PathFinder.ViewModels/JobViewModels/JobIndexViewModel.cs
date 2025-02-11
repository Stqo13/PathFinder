using PathFinder.Data.Models;

namespace PathFinder.ViewModels.JobViewModels
{
    public class JobIndexViewModel
    {
        public IEnumerable<JobInfoViewModel> JobOffers { get; set; }
            = new List<JobInfoViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public List<Sphere> AvailableSpheres { get; set; } = new List<Sphere>();

        public List<int> SelectedSpheres { get; set; } = new List<int>();
    }
}
