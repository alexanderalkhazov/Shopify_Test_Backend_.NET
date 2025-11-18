using System.Text.Json.Serialization;
using API.Models.Shopify.Models;

namespace API.Models.Shopify;

/// <summary>
/// Shopify webhook response
/// </summary>
public class ShopifyWebhookResponse
{
    [JsonPropertyName("webhook")] public ShopifyWebhookInfo Webhook { get; set; } = new();
}

public class ShopifyWebhookInfo
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("topic")] public string Topic { get; set; } = string.Empty;

    [JsonPropertyName("address")] public string Address { get; set; } = string.Empty;

    [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }
}

/// <summary>
/// Shopify webhook creation request
/// </summary>
public class ShopifyWebhookRequest
{
    [JsonPropertyName("webhook")] public ShopifyWebhookData Webhook { get; set; } = new();
}

public class ShopifyWebhookData
{
    [JsonPropertyName("topic")] public string Topic { get; set; } = string.Empty;

    [JsonPropertyName("address")] public string Address { get; set; } = string.Empty;

    [JsonPropertyName("format")] public string Format { get; set; } = "json";
}

/// <summary>
/// Shopify product webhook payload
/// </summary>
public class ShopifyProductWebhook : ShopifyWebhookPayload
{
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;

    [JsonPropertyName("handle")] public string Handle { get; set; } = string.Empty;

    [JsonPropertyName("product_type")] public string ProductType { get; set; } = string.Empty;

    [JsonPropertyName("vendor")] public string Vendor { get; set; } = string.Empty;

    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;

    [JsonPropertyName("variants")] public List<ShopifyVariant> Variants { get; set; } = new();
}

/// <summary>
/// Shopify webhook payload base
/// </summary>
public class ShopifyWebhookPayload
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }
}

/// <summary>
/// Shopify order webhook payload
/// </summary>
public class ShopifyOrderWebhook : ShopifyWebhookPayload
{
    [JsonPropertyName("order_number")] public int OrderNumber { get; set; }

    [JsonPropertyName("email")] public string? Email { get; set; }

    [JsonPropertyName("total_price")] public string TotalPrice { get; set; } = string.Empty;

    [JsonPropertyName("currency")] public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("financial_status")] public string? FinancialStatus { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }

    [JsonPropertyName("customer")] public ShopifyCustomer? Customer { get; set; }

    [JsonPropertyName("line_items")] public List<ShopifyLineItem> LineItems { get; set; } = new();
}