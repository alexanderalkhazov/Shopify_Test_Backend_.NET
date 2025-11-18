using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyOAuthTokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    [JsonPropertyName("scope")]
    public string Scope { get; set; } = string.Empty;
}
