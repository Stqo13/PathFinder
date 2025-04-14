using PathFinder.Data.Models;

public interface IChatService
{
    Task SaveMessageAsync(string senderId, string receiverId, string message);
    Task<List<Message>> GetConversationHistoryAsync(string userId1, string userId2);
    Task MarkMessagesAsReadAsync(string userId, string senderId);
}