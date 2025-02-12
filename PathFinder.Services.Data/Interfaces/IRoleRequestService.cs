using PathFinder.Common;
using PathFinder.ViewModels.RoleRequestViewModel;

namespace PathFinder.Services.Data.Interfaces
{
    public interface IRoleRequestService
    {
        Task SendComanyRoleRequest(RoleRequestSendViewModel model, string userId);

        Task SendInstitutionRoleRequest(RoleRequestSendViewModel model, string userId);

        Task<PaginatedList<RoleRequestInfoViewModel>> GetCompanyRoleRequestsAsync(int page, int pageSize);

        Task<PaginatedList<RoleRequestInfoViewModel>> GetInstitutionRoleRequestsAsync(int page, int pageSize);

        Task AcceptRequestAsync(int requestId, string requestType, string userId);

        Task DeclineRequestAsync(int requestId, string requestType, string userId);
    }
}
