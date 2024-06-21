namespace Infrastructure.Settings;

public class DiscordSettings
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string AuthorizationToken { get; set; }
    public string GrantType { get; set; }
    public string ApiEndpoint { get; set; }
    public string RedirectUri { get; set; }
}