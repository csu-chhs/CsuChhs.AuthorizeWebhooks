using CsuChhs.AuthorizeWebhooks.Clients.Legacy;

namespace CsuChhs.AuthorizeWebhooks;

public interface IAuthorizeLegacy
{
    ITransactionReportingClient Transaction { get; }
}