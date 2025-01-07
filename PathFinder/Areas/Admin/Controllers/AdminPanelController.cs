using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.UserViewModels;

namespace PathFinder.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPanelController(
        IUserService userService,
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
        public IActionResult RoleRequests(int pageIndex = 1)
        {
            return View();
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
