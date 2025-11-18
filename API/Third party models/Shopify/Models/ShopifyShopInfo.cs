using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyShopInfo
{
    [JsonPropertyName("shop")]
    public ShopifyShopDetails Shop { get; set; } = new();
}