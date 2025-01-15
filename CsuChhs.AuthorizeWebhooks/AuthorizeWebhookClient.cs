using CsuChhs.AuthorizeWebhooks.Clients;
using RestSharp;
using RestSharp.Authenticators;

namespace CsuChhs.AuthorizeWebhooks;

public class AuthorizeWebhookClient : IAuthorizeWebhooks
{
    private const string _authorizeUrl = "https://api.authorize.net/rest/v1";
    
    public AuthorizeWebhookClient(string username,
        string password)
    {
        var options = new RestClientOptions(_authorizeUrl)
        {
            Authenticator = new HttpBasicAuthenticator(username, password)
        };
        RestClient restClient = new RestClient(options);
        Webhook = new WebhookClient(restClient);
    }
    
    public IWebhookClient Webhook { get; }
}