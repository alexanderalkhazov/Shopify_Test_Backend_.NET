using API.Models.ThirdParty;

namespace API.Services.Interfaces;

/// <summary>
/// Service for sending Discord webhook notifications
/// </summary>
public interface IDiscordService
{
    Task<bool> SendMessageAsync(string message, string channel);
}