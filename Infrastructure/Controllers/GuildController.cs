using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Infrastructure.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GuildController : ControllerBase
{
    private readonly IGuildApi _guildApi;

    public GuildController(IGuildApi guildApi)
    {
        _guildApi = guildApi;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetGuilds(string tokenType , string accessToken)
    {
        var token = $"{tokenType} {accessToken}";
        Console.WriteLine(token);
        var guilds = await _guildApi.GetGuildsAsync(token);
        return Ok(guilds);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetGuild(string id, string tokenType , string accessToken)
    {
        var token = $"{tokenType} {accessToken}";
        Console.WriteLine(token);
        var guilds = await _guildApi.GetGuildByIdAsync(authorization: token, guildId:id);
        return Ok(guilds);
    }

    [HttpDelete]
    public async Task<IActionResult> LeaveGuild(string id, string tokenType, string accessToken)
    {
        var token = $"{tokenType} {accessToken}";
        Console.WriteLine(token);
        await _guildApi.DeleteGuildAsync(authorization: token, guildId: id);
        return NoContent();
    }
}