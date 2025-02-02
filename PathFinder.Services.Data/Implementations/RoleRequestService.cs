using PathFinder.Data.Models.Enums;
using PathFinder.Data.Models;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.RoleRequestViewModel;
using PathFinder.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using PathFinder.Common;
using Microsoft.AspNetCore.Identity;

namespace PathFinder.Services.Data.Implementations
{
    public class RoleRequestService(
        IRepository<CompanyRoleRequest, int> companyRoleRequestRepository, 
        IRepository<InstitutionRoleRequest, int> institutionRoleRequestRepository,
        UserManager<ApplicationUser> userManager) : IRoleRequestService
    {
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

            await companyRoleRequestRepository.AddAsync(request);
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

        public async Task<PaginatedList<RoleRequestInfoViewModel>> GetCompanyRoleRequestsAsync(int page, int pageSize)
        {
            var query = companyRoleRequestRepository
                .GetAllAttached()
                .Where(r => r.Status == RequestStatus.Pending);

            var paginatedList = await PaginatedList<RoleRequestInfoViewModel>.CreateAsync(
                query.Select(r => new RoleRequestInfoViewModel
                {
                    Id = r.Id,
                    Sender = r.Sender,
                    Description = r.Description,
                    Status = r.Status.ToString()
                }),
                page,
                pageSize
            );

            return paginatedList;
        }

        public async Task<PaginatedList<RoleRequestInfoViewModel>> GetInstitutionRoleRequestsAsync(int page, int pageSize)
        {
            var query = institutionRoleRequestRepository
                .GetAllAttached()
                .Where(r => r.Status == RequestStatus.Pending);

            var paginatedList = await PaginatedList<RoleRequestInfoViewModel>.CreateAsync(
                query.Select(r => new RoleRequestInfoViewModel
                {
                    Id = r.Id,
                    Sender = r.Sender,
                    Description = r.Description,
                    Status = r.Status.ToString()
                }),
                page,
                pageSize
            );

            return paginatedList;
        }

        public async Task AcceptRequestAsync(int requestId, string requestType)
        {
            if (requestType == "Company")
            {
                var request = await companyRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Accepted;
                    await companyRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByEmailAsync(request.Sender);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }
                    await userManager.AddToRoleAsync(user, "Comapny");
                }
            }
            else if (requestType == "Institution")
            {
                var request = await institutionRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Accepted;
                    await institutionRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByEmailAsync(request.Sender);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }
                    await userManager.AddToRoleAsync(user, "Institution");
                }
            }
        }

        public async Task DeclineRequestAsync(int requestId, string requestType)
        {
            if (requestType == "Company")
            {
                var request = await companyRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Declined;
                    await companyRoleRequestRepository.UpdateAsync(request);
                }
            }
            else if (requestType == "Institution")
            {
                var request = await institutionRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Declined;
                    await institutionRoleRequestRepository.UpdateAsync(request);
                }
            }
        }
    }
}
