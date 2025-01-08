using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.RoleRequestViewModel;

namespace PathFinder.Controllers
{
    public class RoleRequestController(
        IRoleRequestService requestService,
        ILogger<RoleRequestController> logger) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendCompanyRoleRequest()
        {
            var model = new RoleRequestSendViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendCompanyRoleRequest(RoleRequestSendViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await requestService.SendComanyRoleRequest(model);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while sending role request. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult SendInstitutionRoleRequest()
        {
            var model = new RoleRequestSendViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendInstitutionRoleRequest(RoleRequestSendViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await requestService.SendInstitutionRoleRequest(model);
            }
            catch (Exception ex)
            {
                logger.LogError($"An error occured while sending role request. {ex.Message}");
                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
