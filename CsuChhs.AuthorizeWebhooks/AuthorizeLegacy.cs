using CsuChhs.AuthorizeWebhooks.Clients.Legacy;
using RestSharp;

namespace CsuChhs.AuthorizeWebhooks;

public class AuthorizeLegacy : IAuthorizeLegacy
{
    private const string _authorizeUrl = "https://api.authorize.net/xml/v1/request.api";

    public AuthorizeLegacy()
    {
        var options = new RestClientOptions(_authorizeUrl);
        
        RestClient client = new RestClient(options);
        Transaction = new TransactionReportingClient(client);
    }
    
    public ITransactionReportingClient Transaction { get; }
}