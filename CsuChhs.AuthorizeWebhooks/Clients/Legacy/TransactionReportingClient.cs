using System.Text.Json;
using CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.RequestModels;
using CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.ResponseModels;
using RestSharp;

namespace CsuChhs.AuthorizeWebhooks.Clients.Legacy;

public class TransactionReportingClient : ITransactionReportingClient
{
    private RestClient _client;
    
    public TransactionReportingClient(RestClient client)
    {
        _client = client;    
    }

    public async Task<GetTransactionDetailsResponse?> GetTransactionDetailsAsync(GetTransactionDetailsRequest request)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        string jsonString = JsonSerializer.Serialize(new { getTransactionDetailsRequest = request }, options);

        var restRequest = new RestRequest();
        restRequest.AddJsonBody(jsonString);

        var response = await _client.ExecuteAsync<GetTransactionDetailsResponse>(restRequest, 
            Method.Post);

        if (response.IsSuccessful)
        {
            return response.Data;
        }

        return null;
    }
}