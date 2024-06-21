using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Infrastructure.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ChannelController : ControllerBase
{
    private readonly IChannelApi _channelApi;
    private readonly DiscordSettings _discordSettings;

    public ChannelController(IChannelApi channelApi, IOptions<DiscordSettings> discordSettings)
    {
        _channelApi = channelApi;
        _discordSettings = discordSettings.Value;
    }

    [HttpGet]
    public async Task<IActionResult> GetChannelsAsync(string guildId)
    {
        var channels = await _channelApi.GetChannelsAsync(guildId:guildId, authorization:_discordSettings.AuthorizationToken);
        return Ok(channels);
    }

    [HttpGet("{channelId}")]
    public async Task<IActionResult> GetChannelAsync(string channelId)
    {
        var channel = await _channelApi.GetChannelByIdAsync(channelId:channelId, authorization:_discordSettings.AuthorizationToken);
        return Ok(channel);
    }

    [HttpPost]
    public async Task<IActionResult> CreateChannelAsync(string guildId, [FromBody] CreateChannelRequest request)
    {
        var channel = await _channelApi.CreateChannelAsync(guildId: guildId, authorization:_discordSettings.AuthorizationToken, request:request);
        return Ok(channel);
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateChannelAsync([FromBody] UpdateChannelRequest request)
    {
        var channel = await _channelApi.UpdateChannelAsync(channelId:request.Id, authorization: _discordSettings.AuthorizationToken, request:request);
        return Ok(channel);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteChannelAsync(string channelId)
    {
        await _channelApi.DeleteChannelAsync(channelId, _discordSettings.AuthorizationToken);
        return NoContent();
    }
}