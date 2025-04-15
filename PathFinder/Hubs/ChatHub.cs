using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

[Authorize]
public class ChatHub : Hub
{
    private readonly IChatService _chatService;

    public ChatHub(IChatService chatService)
    {
        _chatService = chatService;
    }

    public async Task SendMessage(string receiverId, string message)
    {
        var senderId = Context.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(senderId))
            throw new HubException("User not authenticated.");

        await _chatService.SaveMessageAsync(senderId, receiverId, message);

        string groupName = GetChatGroupName(senderId, receiverId);

        await Clients.Group(groupName).SendAsync("ReceiveMessage", senderId, message);
    }

    public async Task LoadMessages(string otherUserId)
    {
        var userId = Context.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            throw new HubException("User not authenticated.");

        var messages = await _chatService.GetConversationHistoryAsync(userId, otherUserId);
        string groupName = GetChatGroupName(userId, otherUserId);

        await Clients.Group(groupName).SendAsync("LoadMessages", messages);
    }

    public async Task JoinConversation(string userId, string receiverId)
    {
        if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(receiverId))
            throw new HubException("Invalid user ID.");

        string groupName = GetChatGroupName(userId, receiverId);

        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        Console.WriteLine($"{userId} joined group {groupName}");
    }

    private string GetChatGroupName(string userId1, string userId2)
    {
        if (userId1.CompareTo(userId2) < 0)
        {
            return $"{userId1}_{userId2}";
        }

        return $"{userId2}_{userId1}";
    }
}
