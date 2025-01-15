using CsuChhs.AuthorizeWebhooks.Clients;

namespace CsuChhs.AuthorizeWebhooks;

public interface IAuthorizeWebhooks
{
    IWebhookClient Webhook { get; }
}