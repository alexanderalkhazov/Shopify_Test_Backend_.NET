namespace API.Configuration;

/// <summary>
/// Shopify configuration settings
/// </summary>
public class ShopifySettings
{
    public string ClientId { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
    public string Scopes { get; set; } = string.Empty;
    public string WebhookSecret { get; set; } = string.Empty;
    public string AppUrl { get; set; } = string.Empty;
    public string RedirectUrl { get; set; } = string.Empty;
    public string ApiVersion { get; set; } = "2024-10";
    public string WebhookEndpoint { get; set; } = "/api/shopify/webhooks";
    public bool EnableWebhooks { get; set; } = true;
    public List<string> RequiredWebhooks { get; set; } = new();

    public string[] GetScopesArray() => Scopes.Split(',', StringSplitOptions.RemoveEmptyEntries)
        .Select(s => s.Trim()).ToArray();
}