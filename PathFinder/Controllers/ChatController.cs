using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathFinder.ViewModels;
using PathFinder.ViewModels.CourseViewModels;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography.Pkcs;

[Authorize]
public class ChatController : Controller
{
    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet]
    public IActionResult Conversation(string receiverId)
    {
        var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var model = new ChatViewModel()
        {
            SenderId = currentUserId,
            ReceiverId = receiverId
        };

        return View(model);
    }
}