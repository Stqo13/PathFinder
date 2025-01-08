using PathFinder.Data.Models.Enums;
using PathFinder.Data.Models;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.RoleRequestViewModel;
using PathFinder.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PathFinder.Services.Data.Implementations
{
    public class RoleRequestService(
        IRepository<CompanyRoleRequest, int> comapnyRoleRequestRepository, 
        IRepository<InstitutionRoleRequest, int> institutionRoleRequestRepository) : IRoleRequestService
    {
        public async Task<IEnumerable<RoleRequestInfoViewModel>> GetAllCompanyRoleRequests()
        {
            var requests = await comapnyRoleRequestRepository
                .GetAllAttached()
                .Where(r => r.Status == RequestStatus.Pending)
                .Select(r => new RoleRequestInfoViewModel()
                {
                    Id = r.Id,
                    Sender = r.Sender,
                    Description = r.Description,
                    Status = r.Status.ToString()
                })
                .AsNoTracking()
                .ToListAsync();

            return requests;    
        }

        public async Task<IEnumerable<RoleRequestInfoViewModel>> GetAllInstitutionRoleRequests()
        {
            var requests = await institutionRoleRequestRepository
                .GetAllAttached()
                .Where(r => r.Status == RequestStatus.Pending)
                .Select(r => new RoleRequestInfoViewModel()
                {
                    Id = r.Id,
                    Sender = r.Sender,
                    Description = r.Description,
                    Status = r.Status.ToString()
                })
                .AsNoTracking()
                .ToListAsync();

            return requests;
        }

        public async Task SendComanyRoleRequest(RoleRequestSendViewModel model)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            var request = new CompanyRoleRequest()
            {
                Id = model.Id,
                Sender = model.Sender,
                Description = model.Description,
                Status = RequestStatus.Pending
            };

            await comapnyRoleRequestRepository.AddAsync(request);
        }

        public async Task SendInstitutionRoleRequest(RoleRequestSendViewModel model)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            var request = new InstitutionRoleRequest()
            {
                Id = model.Id,
                Sender = model.Sender,
                Description = model.Description,
                Status = RequestStatus.Pending
            };

            await institutionRoleRequestRepository.AddAsync(request);
        }
    }
}
