using Infrastructure.Dto_s;
using Refit;

namespace Infrastructure.Interfaces;

public interface IAuthorization
{
    [Post("/oauth2/token")]
    Task<TokenResponse> PostAccessToken(
        [Body(BodySerializationMethod.UrlEncoded)]  TokenRequest request);
}