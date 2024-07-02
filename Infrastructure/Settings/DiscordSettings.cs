namespace Infrastructure.Settings;
/// <summary>
/// Discord settings class.
/// </summary>
public class DiscordSettings
{
    /// <summary>
    /// Application client id. 
    /// </summary>
    public string ClientId { get; set; }
    /// <summary>
    /// Application client secret.
    /// </summary>
    public string ClientSecret { get; set; }
    /// <summary>
    /// User authorization token.
    /// </summary>
    public string AuthorizationToken { get; set; }
    /// <summary>
    /// Token grant type.
    /// </summary>
    public string GrantType { get; set; }
    
    /// <summary>
    /// Discord base api endpoint.
    /// </summary>
    public string ApiEndpoint { get; set; }
    /// <summary>
    /// Application redirect uri.
    /// </summary>
    public string RedirectUri { get; set; }
    /// <summary>
    /// Accept header.
    /// </summary>
    public string Accept { get; set; }
    /// <summary>
    /// Language header.
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// Debug options header.
    /// </summary>
    public string DebugOptions { get; set; }
    /// <summary>
    /// DiscordLocale header.
    /// </summary>
    public string Locale { get; set; }
    /// <summary>
    /// Discord timezone header.
    /// </summary>
    public string Timezone { get; set; }
    /// <summary>
    /// x-super-properties header.
    /// </summary>
    public string XSuperProperties { get; set; }
}