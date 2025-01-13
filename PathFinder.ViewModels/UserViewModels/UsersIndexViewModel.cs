namespace PathFinder.ViewModels.UserViewModels
{
    public class UsersIndexViewModel
    {
        public IEnumerable<AllUsersViewModel> Users { get; set; }
            = new List<AllUsersViewModel>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
