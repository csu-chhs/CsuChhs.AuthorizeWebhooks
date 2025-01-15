using CsuChhs.AuthorizeWebhooks.ResourceModels;

namespace CsuChhs.AuthorizeWebhooks.Clients;

public interface IWebhookClient
{
    /// <summary>
    /// Get all web hooks associated with
    /// this account.
    /// </summary>
    /// <returns></returns>
    Task<List<WebhookResourceModel>?> GetWebhooksAsync();
    
    /// <summary>
    /// Get a specific web hook.
    /// </summary>
    /// <param name="webhookId"></param>
    /// <returns></returns>
    Task<WebhookResourceModel?> GetWebhookAsync(string webhookId);
}