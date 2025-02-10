namespace PathFinder.Services.Data.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string subject, string body);
    }
}
