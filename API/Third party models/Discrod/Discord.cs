namespace API.Models.ThirdParty;

public class DiscordWebhookMessage
{
    public string Content { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public List<DiscordEmbed> Embeds { get; set; } = new();
}

public class DiscordEmbed
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = "3447003"; // Blue color as default
    public List<DiscordField> Fields { get; set; } = new();
    public DiscordFooter? Footer { get; set; }
    public string Timestamp { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
}

public class DiscordField
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public bool Inline { get; set; } = false;
}

public class DiscordFooter
{
    public string Text { get; set; } = string.Empty;
    public string IconUrl { get; set; } = string.Empty;
}