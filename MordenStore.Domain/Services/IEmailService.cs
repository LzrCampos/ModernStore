namespace MordenStore.Domain.Services
{
    public interface IEmailService
    {
        void Send(string name, string email, string subject, string body);

        // sendgreed
    }
}
