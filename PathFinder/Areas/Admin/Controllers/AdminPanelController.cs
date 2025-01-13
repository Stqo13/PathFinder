using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.UserViewModels;
using PathFinder.ViewModels.RoleRequestViewModel;

namespace PathFinder.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPanelController(
        IUserService userService,
        IRoleRequestService requestService,
        ILogger<AdminPanelController> logger) : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserManagement(int pageNumber = 1)
        {
            try
            {
                int pageSize = 5;
                var users = await userService.GetAllUsersAsync(pageNumber, pageSize);
                var totalPages = await userService.GetTotalPagesAsync(pageSize);

                var model = new UsersIndexViewModel()
                {
                    Users = users,
                    CurrentPage = pageNumber,
                    TotalPages = totalPages
                };

                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while fetching the users. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> RoleRequests(int companyPage = 1, int institutionPage = 1, int pageSize = 3)
        {
            try
            {
                var companyRequests = await requestService.GetCompanyRoleRequestsAsync(companyPage, pageSize);
                var institutionRequests = await requestService.GetInstitutionRoleRequestsAsync(institutionPage, pageSize);

                var model = new AdminRoleRequestsViewModel
                {
                    CompanyRequests = companyRequests,
                    InstitutionRequests = institutionRequests
                };

                ViewBag.CompanyPagination = companyRequests;
                ViewBag.InstitutionPagination = institutionRequests;

                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occurred while fetching the role requests. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AcceptRequest(int requestId, string requestType)
        {
            try
            {
                await requestService.AcceptRequestAsync(requestId, requestType);
                return RedirectToAction(nameof(RoleRequests));
            }
            catch (Exception ex)
            {
                logger.LogError($"Error accepting request: {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeclineRequest(int requestId, string requestType)
        {
            try
            {
                await requestService.DeclineRequestAsync(requestId, requestType);
                return RedirectToAction(nameof(RoleRequests));
            }
            catch (Exception ex)
            {
                logger.LogError($"Error declining request: {ex.Message}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            bool userExists = await userService
                .UserExistsByIdAsync(userId);

            if (!userExists)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            bool assignResult = await userService
                .AssignUserToRoleAsync(userId, role);

            if (!assignResult)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            return RedirectToAction(nameof(UserManagement));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            bool userExists = await userService
                .UserExistsByIdAsync(userId);

            if (!userExists)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            bool removeResult = await userService
                .RemoveUserRoleAsync(userId, role);

            if (!removeResult)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            return RedirectToAction(nameof(UserManagement));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            bool userExists = await userService
                .UserExistsByIdAsync(userId);

            if (!userExists)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            bool removeResult = await userService
                .DeleteUserAsync(userId);

            if (!removeResult)
            {
                return RedirectToAction(nameof(UserManagement));
            }

            return RedirectToAction(nameof(UserManagement));
        }

    }
}
