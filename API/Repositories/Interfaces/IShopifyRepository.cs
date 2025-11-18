using API.Data.Entities;
using API.Models.Shopify;

namespace API.Repositories.Interfaces;

/// <summary>
/// Repository for managing Shopify data
/// </summary>
public interface IShopifyRepository
{
    // Shop management
    Task<ShopifyShops?> GetShopByDomainAsync(string shopDomain);
    Task<ShopifyShops?> GetShopByIdAsync(int shopId);
    Task<List<ShopifyShops>> GetActiveShopsAsync();
    Task<List<ShopifyShops>> GetAllShopsAsync();
    Task AddShopAsync(ShopifyShops shop);
    Task UpdateShopAsync(ShopifyShops shop);
    Task DeleteShopAsync(int shopId);

    // Webhook management
    Task<List<ShopifyWebhook>> GetWebhooksByShopIdAsync(int shopId);
    Task<ShopifyWebhook?> GetWebhookByIdAsync(int webhookId);
    Task AddWebhookAsync(ShopifyWebhook webhook);
    Task UpdateWebhookAsync(ShopifyWebhook webhook);
    Task DeleteWebhookAsync(int webhookId);
    Task DeleteWebhooksByShopIdAsync(int shopId);

    // Analytics and reporting
    Task<int> GetActiveShopCountAsync();
    Task<List<ShopifyShops>> GetRecentInstallationsAsync(int days = 30);
    Task<List<ShopifyShops>> GetShopsWithoutWebhooksAsync();
}