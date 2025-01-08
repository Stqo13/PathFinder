using PathFinder.ViewModels.RoleRequestViewModel;

namespace PathFinder.Services.Data.Interfaces
{
    public interface IRoleRequestService
    {
        Task SendComanyRoleRequest(RoleRequestSendViewModel model);

        Task SendInstitutionRoleRequest(RoleRequestSendViewModel model);
    }
}
