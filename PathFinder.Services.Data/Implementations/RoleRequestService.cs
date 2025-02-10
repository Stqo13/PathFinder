using PathFinder.Data.Models.Enums;
using PathFinder.Data.Models;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.RoleRequestViewModel;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Server;

namespace PathFinder.Services.Data.Implementations
{
    public class RoleRequestService(
        IRepository<CompanyRoleRequest, int> companyRoleRequestRepository, 
        IRepository<InstitutionRoleRequest, int> institutionRoleRequestRepository,
        IEmailSenderService emailSenderService,
        UserManager<ApplicationUser> userManager) : IRoleRequestService
    {
        public async Task SendComanyRoleRequest(RoleRequestSendViewModel model, string userId)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            var request = new CompanyRoleRequest()
            {
                Id = model.Id,
                Sender = model.Sender,
                SenderId = userId,
                Description = model.Description,
                Status = RequestStatus.Pending
            };

            await companyRoleRequestRepository.AddAsync(request);
        }

        public async Task SendInstitutionRoleRequest(RoleRequestSendViewModel model, string userId)
        {
            if (model == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            var request = new InstitutionRoleRequest()
            {
                Id = model.Id,
                Sender = model.Sender,
                SenderId = userId,
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

        public async Task AcceptRequestAsync(int requestId, string requestType, string userId)
        {
            if (requestType == "Company")
            {
                var request = await companyRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Accepted;
                    await companyRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByIdAsync(request.SenderId);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }
                    await userManager.AddToRoleAsync(user, "Company");

                    string subject = "Company Role Request Accepted";
                    string body = $"Comany role request was accpeted for user {user.UserName}";

                    await emailSenderService.SendEmailAsync(subject, body);
                }
            }
            else if (requestType == "Institution")
            {
                var request = await institutionRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Accepted;
                    await institutionRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByIdAsync(request.SenderId);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }
                    await userManager.AddToRoleAsync(user, "Institution");

                    string subject = "Institution Role Request Accepted";
                    string body = $"Institution role request was accpeted for user {user.UserName}";

                    await emailSenderService.SendEmailAsync(subject, body);
                }
            }
        }

        public async Task DeclineRequestAsync(int requestId, string requestType, string userId)
        {
            if (requestType == "Company")
            {
                var request = await companyRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Declined;
                    await companyRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByIdAsync(request.SenderId);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }

                    string subject = "Company Role Request Declined";
                    string body = $"Comany role request was declined for user {user.UserName}";

                    await emailSenderService.SendEmailAsync(subject, body);
                }
            }
            else if (requestType == "Institution")
            {
                var request = await institutionRoleRequestRepository.GetByIdAsync(requestId);
                if (request != null)
                {
                    request.Status = RequestStatus.Declined;
                    await institutionRoleRequestRepository.UpdateAsync(request);

                    var user = await userManager.FindByIdAsync(request.SenderId);
                    if (user == null)
                    {
                        throw new NullReferenceException("User not found!");
                    }

                    string subject = "Institution Role Request Declined";
                    string body = $"Institution role request was declined for user {user.UserName}";

                    await emailSenderService.SendEmailAsync(subject, body);
                }
            }
        }
    }
}
