using Infrastructure.Dto_s.Guild.Requests;
using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Refit;

namespace Infrastructure.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GuildController : ControllerBase
{
    private readonly IGuildApi _guildApi;
    private readonly DiscordSettings _discordSettings;

    public GuildController(IGuildApi guildApi, IOptions<DiscordSettings> discordSettings)
    {
        _guildApi = guildApi;
        _discordSettings = discordSettings.Value;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetGuilds()
    {
        var guilds = await _guildApi.GetGuildsAsync(authorization: _discordSettings.AuthorizationToken);
        return Ok(guilds);
    }
    
    [HttpGet("{guildId}")]
    public async Task<IActionResult> GetGuild(string guildId)
    {
        var guilds = await _guildApi.GetGuildByIdAsync(authorization: _discordSettings.AuthorizationToken, guildId: guildId);
        return Ok(guilds);
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateGuild( [FromBody] UpdateGuildRequest request)
    {
        var guild = await _guildApi.UpdateGuildAsync(authorization:_discordSettings.AuthorizationToken, guildId: request.Id, request: request);

        return Ok(guild);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteGuildAsync(string guildId)
    {
        await _guildApi.DeleteGuildAsync(authorization: _discordSettings.AuthorizationToken, guildId: guildId);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateGuildAsync([FromBody] CreateGuildRequest request)
    {
        var guild = await _guildApi.CreateGuildAsync(authorization:_discordSettings.AuthorizationToken, request: request);
        return Ok(guild);
    }
}