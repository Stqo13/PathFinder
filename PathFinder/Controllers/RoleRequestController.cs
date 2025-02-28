using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using PathFinder.Services.Data.Interfaces;
using PathFinder.ViewModels.RoleRequestViewModel;
using System.Security.Claims;
using PathFinder.Common.Helpers;

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
                string userId = ControllerHelper.GetCurrentClientId(User);

                await requestService.SendComanyRoleRequest(model, userId);
            }
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
                string userId = ControllerHelper.GetCurrentClientId(User);

                await requestService.SendInstitutionRoleRequest(model, userId);
            }
            catch (NullReferenceException nex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {nex.Message}");
                return RedirectToAction("Error", "Home", new { code = 404 });
            }
            catch (InvalidOperationException iex)
            {
                logger.LogError($"An error occured while adding the membership plan to personal hall. {iex.Message}");
                return RedirectToAction("Error", "Home", new { code = 500 });
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
