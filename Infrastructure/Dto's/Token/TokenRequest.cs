using Refit;

namespace Infrastructure.Dto_s;

public class TokenRequest
{
    [AliasAs("grant_type")]
    public string GrantType { get; set; }

    [AliasAs("client_id")]
    public string ClientId { get; set; }

    [AliasAs("client_secret")]
    public string ClientSecret { get; set; }

    [AliasAs("code")]
    public string Code { get; set; }

    [AliasAs("redirect_uri")]
    public string RedirectUri { get; set; }
}