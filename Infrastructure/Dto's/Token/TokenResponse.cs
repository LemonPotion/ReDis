using Refit;

namespace Infrastructure.Dto_s.Token;
/// <summary>
/// Authentication token response dto.
/// </summary>
public class TokenResponse
{
    /// <summary>
    /// Token type.
    /// </summary>
    [AliasAs("token_type")]
    public string token_type { get; set; }
    /// <summary>
    /// Discord access token.
    /// </summary>
    [AliasAs("access_token")]
    public string access_token { get; set; }
    /// <summary>
    /// Token scopes.
    /// </summary>
    [AliasAs("scope")]
    public string scope { get; set; }
}
