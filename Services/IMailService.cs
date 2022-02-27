using FacturaStoreApi.Models;

namespace FacturaStoreApi.Services;

public interface IMailService
{
    Task SendEmailAsync(MailRequest mailRequest);
}