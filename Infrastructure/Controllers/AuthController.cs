using Infrastructure.Dto_s;
using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Infrastructure.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthorization _authorization;
    private readonly DiscordSettings _discordSettings;
    
    public AuthController(IAuthorization authorization, IOptions<DiscordSettings> discordSettings)
    {
        _authorization = authorization;
        _discordSettings = discordSettings.Value;
    }
    [HttpGet]
    public async Task<IActionResult> GetToken(string code)
    {
        var tokenRequest = new TokenRequest
        {
            GrantType = _discordSettings.GrantType,
            ClientId = _discordSettings.ClientId,
            ClientSecret = _discordSettings.ClientSecret,
            Code = code,
            RedirectUri = _discordSettings.RedirectUri
        };
        var tokenResponse = await _authorization.PostAccessToken(tokenRequest);
        
        return Ok(tokenResponse);
    }
}