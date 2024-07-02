using Infrastructure.Dto_s;
using Infrastructure.Dto_s.Token;
using Refit;

namespace Infrastructure.Interfaces;
/// <summary>
/// Discord application authorization refit interface.
/// </summary>
public interface IAuthorization
{
    /// <summary>
    /// Creates user token via application.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Token.</returns>
    [Post("/oauth2/token")]
    Task<TokenResponse> PostAccessToken(
        [Body(BodySerializationMethod.UrlEncoded)]  TokenRequest request);
}