using Infrastructure.Dto_s.Guild.Requests;
using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Refit;

namespace Infrastructure.Controllers;
/// <summary>
/// Guild api controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class GuildController : ControllerBase
{
    /// <summary>
    /// Discord guilds api interface.
    /// </summary>
    private readonly IGuildApi _guildApi;
    public GuildController(IGuildApi guildApi)
    {
        _guildApi = guildApi;
    }
    /// <summary>
    /// Gets all current user guilds.
    /// </summary>
    /// <returns>List of guilds.</returns>
    [HttpGet]
    public async Task<IActionResult> GetGuilds()
    {
        var guilds = await _guildApi.GetGuildsAsync();
        return Ok(guilds);
    }
    /// <summary>
    /// Gets guilds by id.
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns>Guilds info.</returns>
    [HttpGet("{guildId}")]
    public async Task<IActionResult> GetGuild(string guildId)
    {
        var guilds = await _guildApi.GetGuildByIdAsync(guildId);
        return Ok(guilds);
    }
    /// <summary>
    /// Updates guild info by id.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Updated guild info.</returns>
    [HttpPatch]
    public async Task<IActionResult> UpdateGuild( [FromBody] UpdateGuildRequest request)
    {
        var guild = await _guildApi.UpdateGuildAsync(request.Id, request);

        return Ok(guild);
    }
    /// <summary>
    /// Leaves guild by id.
    /// </summary>
    /// <param name="guildId"></param>
    [HttpDelete]
    public async Task<IActionResult> DeleteGuildAsync(string guildId)
    {
        await _guildApi.DeleteGuildAsync(guildId);
        return NoContent();
    }
    /// <summary>
    /// Creates guild.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Guild info.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateGuildAsync([FromBody] CreateGuildRequest request)
    {
        var guild = await _guildApi.CreateGuildAsync(request);
        return Ok(guild);
    }
}