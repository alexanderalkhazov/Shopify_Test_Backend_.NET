using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyShopDetails
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;

    [JsonPropertyName("domain")] public string Domain { get; set; } = string.Empty;

    [JsonPropertyName("myshopify_domain")] public string MyshopifyDomain { get; set; } = string.Empty;

    [JsonPropertyName("shop_owner")] public string ShopOwner { get; set; } = string.Empty;

    [JsonPropertyName("plan_name")] public string PlanName { get; set; } = string.Empty;

    [JsonPropertyName("country_code")] public string CountryCode { get; set; } = string.Empty;

    [JsonPropertyName("currency")] public string Currency { get; set; } = string.Empty;
}