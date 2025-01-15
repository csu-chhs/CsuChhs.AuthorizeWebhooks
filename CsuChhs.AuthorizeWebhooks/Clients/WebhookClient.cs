using CsuChhs.AuthorizeWebhooks.ResourceModels;
using RestSharp;

namespace CsuChhs.AuthorizeWebhooks.Clients;

public class WebhookClient : IWebhookClient
{
    private readonly RestClient _client;
    
    public WebhookClient(RestClient client)
    {
        _client = client;    
    }
    
    public async Task<List<WebhookResourceModel>?> GetWebhooksAsync()
    {
        var request = new RestRequest($"webhooks");
        var response = await _client.ExecuteAsync<List<WebhookResourceModel>>(request);
        return response.Data;
    }

    public async Task<WebhookResourceModel?> GetWebhookAsync(string webhookId)
    {
        var request = new RestRequest($"webhooks/{webhookId}");
        var response = await _client.ExecuteAsync<WebhookResourceModel>(request);
        return response.Data;
    }
}