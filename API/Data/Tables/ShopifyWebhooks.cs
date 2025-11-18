using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Entities;

/// <summary>
/// Shopify webhook record for tracking
/// </summary>
[Table("shopify_webhooks")]
public class ShopifyWebhook
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("shop_id")]
    public int ShopId { get; set; }

    [Required]
    [Column("webhook_id")]
    [MaxLength(50)]
    public string WebhookId { get; set; } = string.Empty;

    [Required]
    [Column("topic")]
    [MaxLength(100)]
    public string Topic { get; set; } = string.Empty;

    [Required]
    [Column("address")]
    [MaxLength(500)]
    public string Address { get; set; } = string.Empty;

    [Column("is_active")]
    public bool IsActive { get; set; } = true;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    [ForeignKey("ShopId")]
    public ShopifyShops Shop { get; set; } = null!;
}