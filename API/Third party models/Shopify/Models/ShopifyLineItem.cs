using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyLineItem
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("product_id")] public long ProductId { get; set; }

    [JsonPropertyName("variant_id")] public long VariantId { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;

    [JsonPropertyName("quantity")] public int Quantity { get; set; }

    [JsonPropertyName("price")] public string Price { get; set; } = string.Empty;
}