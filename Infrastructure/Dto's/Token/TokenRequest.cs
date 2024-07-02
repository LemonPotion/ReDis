using Refit;

namespace Infrastructure.Dto_s.Token;
/// <summary>
/// Authentication token request dto.
/// </summary>
public class TokenRequest
{
    /// <summary>
    /// Token grant type.
    /// </summary>
    [AliasAs("grant_type")]
    public string GrantType { get; set; }
    /// <summary>
    /// Discord application client id.
    /// </summary>
    [AliasAs("client_id")]
    public string ClientId { get; set; }
    /// <summary>
    /// Discord application client secret.
    /// </summary>
    [AliasAs("client_secret")]
    public string ClientSecret { get; set; }
    /// <summary>
    /// Discord redirect link code
    /// </summary>
    [AliasAs("code")]
    public string Code { get; set; }
    /// <summary>
    /// Discord application redirect uri
    /// </summary>
    [AliasAs("redirect_uri")]
    public string RedirectUri { get; set; }
}