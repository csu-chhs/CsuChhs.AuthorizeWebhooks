namespace CsuChhs.AuthorizeWebhooks.ResourceModels.Legacy.RequestModels;

public class MerchantAuthentication
{
    public MerchantAuthentication(string name,
        string transactionKey)
    {
        Name = name;
        TransactionKey = transactionKey;
    }
    
    public string Name { get; set; }
    public string TransactionKey { get; set; }
}