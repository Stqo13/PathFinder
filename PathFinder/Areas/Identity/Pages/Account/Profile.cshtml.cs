using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using PathFinder.Data.Models;
using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Repository.Interfaces;

namespace PathFinder.Areas.Identity.Pages.Account
{
    public class ProfileModel(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IRepository<UserCourse, object> userCourseRespository,
        IRepository<UserJob, object> userJobRepository,
        ILogger<ProfileModel> logger)
        : PageModel
    {
        public bool IsEditModeOn { get; set; }

        [BindProperty]
        public ApplicationUser CurrentUser { get; set; } = null!;

        public List<string> Roles { get; set; } = new List<string>();

        public List<Course> CoursesEnrolled { get; set; } = new List<Course>();

        public List<Job> JobsEnrolled { get; set; } = new List<Job>();

        public async Task<IActionResult> OnGetAsync()
        {
            this.IsEditModeOn = false;

            string userId = userManager.GetUserId(User)!;

            var userWithCourses = await userCourseRespository
                .GetAllAttached()
                .Where(uc => uc.UserId == userId)
                .Select(uc => new
                {
                    User = uc.User,
                    Course = uc.Course
                })
                .ToListAsync();

            var userWithJobs = await userJobRepository
                .GetAllAttached()
                .Where(uj => uj.UserId == userId)
                .Select(uj => new
                {
                    User = uj.User,
                    Job = uj.Job
                })
                .ToListAsync();

            if (userWithCourses.Any() || userWithJobs.Any())
            {
                CurrentUser = userWithCourses.FirstOrDefault()?.User ?? userWithJobs.FirstOrDefault()?.User;

                CoursesEnrolled = userWithCourses.Select(uc => uc.Course).ToList();
                JobsEnrolled = userWithJobs.Select(uj => uj.Job).ToList();

                Roles.AddRange(await userManager.GetRolesAsync(CurrentUser));

                return Page();
            }

            CurrentUser = await userManager.FindByIdAsync(userId);

            if (CurrentUser == null)
            {
                logger.LogError("User not found");
                ViewData["ErrorMessage"] = "User not found";
                return NotFound();
            }

            Roles.AddRange(await userManager.GetRolesAsync(CurrentUser));

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                logger.LogError("User not found");
                ViewData["ErrorMessage"] = "User not found";
                return NotFound();
            }

            CurrentUser = user;

            return Page();
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await userManager.FindByIdAsync(CurrentUser.Id);
            if (user == null)
            {
                logger.LogError("User not found");
                ViewData["ErrorMessage"] = "User not found";
                return NotFound();
            }

            user.FirstName = CurrentUser.FirstName;
            user.LastName = CurrentUser.LastName;
            user.Email = CurrentUser.Email;
            user.PhoneNumber = CurrentUser.PhoneNumber;

            var result = await userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            return RedirectToPage("/Account/Profile");
        }

        public async Task<IActionResult> OnPostChangeMode()
        {
            this.IsEditModeOn = true;
            string userId = userManager.GetUserId(User)!;

            CurrentUser = await userManager.FindByIdAsync(userId);
            return Page();
        }
    }
}