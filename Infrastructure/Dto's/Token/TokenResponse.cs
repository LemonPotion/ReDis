using Refit;

namespace Infrastructure.Dto_s;

public class TokenResponse
{
    [AliasAs("token_type")]
    public string token_type { get; set; }
    
    [AliasAs("access_token")]
    public string access_token { get; set; }
    
    [AliasAs("scope")]
    public string scope { get; set; }
}
