using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace PathFinder.Common.Helpers
{
    public static class ControllerHelper 
    {
        public static string GetCurrentClientId(ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }
    }
}
