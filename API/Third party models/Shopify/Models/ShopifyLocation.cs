using System.Text.Json.Serialization;

namespace API.Models.Shopify.Models;

public class ShopifyLocation
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

    [JsonPropertyName("address1")] public string? Address1 { get; set; }

    [JsonPropertyName("address2")] public string? Address2 { get; set; }

    [JsonPropertyName("city")] public string? City { get; set; }

    [JsonPropertyName("zip")] public string? Zip { get; set; }

    [JsonPropertyName("province")] public string? Province { get; set; }

    [JsonPropertyName("country")] public string? Country { get; set; }

    [JsonPropertyName("phone")] public string? Phone { get; set; }

    [JsonPropertyName("country_code")] public string? CountryCode { get; set; }

    [JsonPropertyName("country_name")] public string? CountryName { get; set; }

    [JsonPropertyName("province_code")] public string? ProvinceCode { get; set; }

    [JsonPropertyName("legacy")] public bool Legacy { get; set; }

    [JsonPropertyName("active")] public bool Active { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("localized_country_name")]
    public string? LocalizedCountryName { get; set; }

    [JsonPropertyName("localized_province_name")]
    public string? LocalizedProvinceName { get; set; }
}