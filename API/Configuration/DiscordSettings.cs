namespace API.Configuration;

/// <summary>
/// Discord webhook configuration settings
/// </summary>
public class DiscordSettings
{
    public string WebhookUrl { get; set; } = string.Empty;
    public string InstallsWebhookUrl { get; set; } = string.Empty;
    public string TraceAndLogsUrl { get; set; } = string.Empty;
    public string BotName { get; set; } = "Backend API";
    public string AvatarUrl { get; set; } = string.Empty;
    public bool Enabled { get; set; } = true;
}