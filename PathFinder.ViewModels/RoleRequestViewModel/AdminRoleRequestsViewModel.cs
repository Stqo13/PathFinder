namespace PathFinder.ViewModels.RoleRequestViewModel
{
    public class AdminRoleRequestsViewModel
    {
        public IEnumerable<RoleRequestInfoViewModel> CompanyRequests { get; set; }
            = new List<RoleRequestInfoViewModel>();
        public IEnumerable<RoleRequestInfoViewModel> InstitutionRequests { get; set; }
            = new List<RoleRequestInfoViewModel>();
    }
}
