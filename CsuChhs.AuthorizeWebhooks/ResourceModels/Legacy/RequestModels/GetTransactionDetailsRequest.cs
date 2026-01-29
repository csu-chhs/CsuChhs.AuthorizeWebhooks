namespace CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.RequestModels;

public class GetTransactionDetailsRequest
{
    public GetTransactionDetailsRequest(string name,
        string transactionKey,
        string transactionId)
    {
        MerchantAuthentication = new(name, transactionKey);
        TransId = transactionId;
    }
    
    public MerchantAuthentication MerchantAuthentication { get; set; }
    public string TransId { get; set; }
}