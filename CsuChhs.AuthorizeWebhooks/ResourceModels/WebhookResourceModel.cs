namespace CsuChhs.AuthorizeWebhooks.ResourceModels;

public class WebhookResourceModel
{
    public WebhookResourceModel()
    {
        WebhookId = string.Empty;
        Name = string.Empty;
        Status = string.Empty;
        Url = string.Empty;
        EventTypes = new();
    }

    public string WebhookId { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string Url { get; set; }
    public List<string> EventTypes { get; set; }
}