namespace PathFinder.ViewModels.JobViewModels
{
    public class JobIndexViewModel
    {
        public IEnumerable<JobInfoViewModel> JobOffers { get; set; }
            = new List<JobInfoViewModel>(); 

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
