using Microsoft.EntityFrameworkCore;
using PathFinder.Data;
using PathFinder.Data.Models;
using PathFinder.Data.Repository.Interfaces;

public class ChatService(
        IRepository<Message, int> messageRepository) : IChatService
{
    public async Task SaveMessageAsync(string senderId, string receiverId, string message)
    {
        var newMessage = new Message
        {
            SenderId = senderId,
            ReceiverId = receiverId,
            Content = message,
            ReceiveDate = DateTime.UtcNow,
            IsRead = false
        };

        messageRepository.AddAsync(newMessage);
    }

    public async Task<List<Message>> GetConversationHistoryAsync(string userId1, string userId2)
    {
        return await messageRepository.GetAllAttached()
            .Where(m => (m.SenderId == userId1 && m.ReceiverId == userId2) ||
                        (m.SenderId == userId2 && m.ReceiverId == userId1))
            .OrderBy(m => m.ReceiveDate)
            .ToListAsync();
    }

    public async Task MarkMessagesAsReadAsync(string userId, string senderId)
    {
        var unreadMessages = await messageRepository.GetAllAttached()
            .Where(m => m.ReceiverId == userId && m.SenderId == senderId && !m.IsRead)
            .ToListAsync();

        foreach (var msg in unreadMessages)
        {
            msg.IsRead = true;
        }

    }
}