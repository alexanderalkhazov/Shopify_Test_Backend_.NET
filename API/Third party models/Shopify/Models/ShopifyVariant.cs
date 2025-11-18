using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyVariant
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;

    [JsonPropertyName("price")] public string Price { get; set; } = string.Empty;

    [JsonPropertyName("sku")] public string? Sku { get; set; }

    [JsonPropertyName("inventory_quantity")]
    public int InventoryQuantity { get; set; }
}