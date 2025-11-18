using System.Text;
using System.Text.Json;
using API.Configuration;
using Microsoft.Extensions.Options;
using API.Services.Interfaces;
using API.Models.ThirdParty;

namespace API.Services.Implementations;

/// <summary>
/// Service for sending Discord webhook notifications
/// </summary>
public class DiscordService : IDiscordService
{
    private readonly HttpClient _httpClient;
    private readonly DiscordSettings _settings;
    private readonly ILogger<DiscordService> _logger;

    public DiscordService(HttpClient httpClient, IOptions<DiscordSettings> settings, ILogger<DiscordService> logger)
    {
        _httpClient = httpClient;
        _settings = settings.Value;
        _logger = logger;
    }

    public async Task<bool> SendMessageAsync(string message, string channel)
    {
        if (!_settings.Enabled || string.IsNullOrEmpty(_settings.WebhookUrl))
        {
            _logger.LogWarning("Discord notifications are disabled or webhook URL is not configured");
            return false;
        }

        try
        {
            var payload = new DiscordWebhookMessage
            {
                Content = message,
                Username = _settings.BotName,
                AvatarUrl = _settings.AvatarUrl
            };

            return await SendWebhookAsync(payload, channel);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending Discord message: {Message}", message);
            return false;
        }
    }
    
    private async Task<bool> SendWebhookAsync(DiscordWebhookMessage payload, string channel)
    {
        try
        {
            var json = JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            });

            var requiredWebhookUrl = channel switch
            {
                "installs" => _settings.InstallsWebhookUrl,
                "traces" => _settings.TraceAndLogsUrl,
                _ => _settings.WebhookUrl
            };
            
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(requiredWebhookUrl, content);

            if (response.IsSuccessStatusCode)
            {
                _logger.LogDebug("Discord webhook sent successfully");
                return true;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Discord webhook failed with status {StatusCode}: {Error}",
                    response.StatusCode, errorContent);
                return false;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception sending Discord webhook");
            return false;
        }
    }
}