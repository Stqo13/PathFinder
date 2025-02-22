using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.UserViewModels;

namespace PathFinder.Services.Data.Implementations
{
    public class UserService(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
        : IUserService
    {
        public async Task<bool> AssignUserToRoleAsync(string userId, string roleName)
        {
            ApplicationUser? user = await userManager.FindByIdAsync(userId.ToString());

            if (user == null || !(await roleManager.RoleExistsAsync(roleName)))
            {
                return false;
            }

            if (!await userManager.IsInRoleAsync(user, roleName))
            {
                IdentityResult result = await userManager.AddToRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            ApplicationUser? user = await userManager.FindByIdAsync(userId.ToString());

            if (user == null)
            {
                return false;
            }

            IdentityResult? result = await userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<AllUsersViewModel>> GetAllUsersAsync(int pageNumber = 1, int pageSize = 5)
        {
            var users = await userManager.Users
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();

            var userViewModels = new List<AllUsersViewModel>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);

                userViewModels.Add(new AllUsersViewModel()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Roles = roles.ToList()
                });
            }

            return userViewModels;
        }

        public async Task<int> GetTotalPagesAsync(int pageSize = 5)
        {
            var totalUsers = await userManager.Users.CountAsync();
            return (int)Math.Ceiling(totalUsers / (double)pageSize);
        }

        public async Task<bool> RemoveUserFromRoleAsync(string userId, string roleName)
        {
            ApplicationUser? user = await userManager.FindByIdAsync(userId.ToString());

            if (user == null || !(await roleManager.RoleExistsAsync(roleName)))
            {
                return false;
            }

            if (await userManager.IsInRoleAsync(user, roleName))
            {
                IdentityResult? result = await userManager.RemoveFromRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> RemoveUserRoleAsync(string userId, string roleName)
        {
            ApplicationUser? user = await userManager
                .FindByIdAsync(userId.ToString());

            bool roleExists = await roleManager.RoleExistsAsync(roleName);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, roleName);

            if (alreadyInRole)
            {
                IdentityResult? result = await userManager
                    .RemoveFromRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> UserExistsByIdAsync(string userId)
        {
            ApplicationUser? user = await userManager.FindByIdAsync(userId.ToString());

            return user != null;
        }
    }
}
