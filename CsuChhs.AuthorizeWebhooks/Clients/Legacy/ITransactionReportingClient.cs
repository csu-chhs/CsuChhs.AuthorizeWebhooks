using CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.RequestModels;
using CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.ResponseModels;

namespace CsuChhs.AuthorizeWebhooks.Clients.Legacy;

public interface ITransactionReportingClient
{
    Task<GetTransactionDetailsResponse?> GetTransactionDetailsAsync(GetTransactionDetailsRequest request);
}