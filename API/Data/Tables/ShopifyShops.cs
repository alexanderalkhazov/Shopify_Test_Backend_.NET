using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Models.Shopify;

namespace API.Data.Entities;

[Table("shopify_shops")]
public class ShopifyShops
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("shop_domain")]
    [MaxLength(255)]
    public string ShopDomain { get; set; } = string.Empty;

    [Required]
    [Column("access_token")]
    [MaxLength(255)]
    public string AccessToken { get; set; } = string.Empty;

    [Column("scopes")]
    [MaxLength(1000)]
    public string Scopes { get; set; } = string.Empty;

    [Column("shop_name")]
    [MaxLength(255)]
    public string? ShopName { get; set; }

    [Column("shop_email")]
    [MaxLength(255)]
    public string? ShopEmail { get; set; }

    [Column("shop_owner")]
    [MaxLength(255)]
    public string? ShopOwner { get; set; }

    [Column("plan_name")]
    [MaxLength(100)]
    public string? PlanName { get; set; }

    [Column("country_code")]
    [MaxLength(3)]
    public string? CountryCode { get; set; }

    [Column("currency")]
    [MaxLength(3)]
    public string? Currency { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; } = true;

    [Column("webhooks_configured")]
    public bool WebhooksConfigured { get; set; } = false;

    [Column("installed_at")]
    public DateTime InstalledAt { get; set; } = DateTime.UtcNow;

    [Column("last_activity")]
    public DateTime? LastActivity { get; set; }

    [Column("uninstalled_at")]
    public DateTime? UninstalledAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation property
    public List<ShopifyWebhook> Webhooks { get; set; } = new();

    public string[] GetScopesArray() => Scopes.Split(',', StringSplitOptions.RemoveEmptyEntries)
        .Select(s => s.Trim()).ToArray();
}