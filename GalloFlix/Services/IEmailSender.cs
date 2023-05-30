namespace GalloFlix.Services;

    public interface IEmailSender
    {
        Task SenderEmailAsync(string email, string subject, string htmlMass)
    }
