using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Implementations;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.UserViewModels;

namespace PathFinder.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPanelController(
        IUserService userService) : Controller
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
            catch (Exception)
            {
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
                return RedirectToAction(nameof(Index));
            }

            bool assignResult = await userService
                .AssignUserToRoleAsync(userId, role);

            if (!assignResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            bool userExists = await userService
                .UserExistsByIdAsync(userId);

            if (!userExists)
            {
                return RedirectToAction(nameof(Index));
            }

            bool removeResult = await userService
                .RemoveUserRoleAsync(userId, role);

            if (!removeResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            bool userExists = await userService
                .UserExistsByIdAsync(userId);

            if (!userExists)
            {
                return RedirectToAction(nameof(Index));
            }

            bool removeResult = await userService
                .DeleteUserAsync(userId);

            if (!removeResult)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
