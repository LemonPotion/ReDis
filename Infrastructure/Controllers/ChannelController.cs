using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Infrastructure.Controllers;
/// <summary>
/// Discord channels api controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ChannelController : ControllerBase
{
    /// <summary>
    /// Discord channel api interface.
    /// </summary>
    private readonly IChannelApi _channelApi;
    
    public ChannelController(IChannelApi channelApi)
    {
        _channelApi = channelApi;
    }
    /// <summary>
    /// Gets all guild channels.
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns>List of channels.</returns>
    [HttpGet]
    public async Task<IActionResult> GetChannelsAsync(string guildId)
    {
        var channels = await _channelApi.GetChannelsAsync(guildId);
        return Ok(channels);
    }
    /// <summary>
    /// Gets channel by id.
    /// </summary>
    /// <param name="channelId"></param>
    /// <returns>Channel info.</returns>
    [HttpGet("{channelId}")]
    public async Task<IActionResult> GetChannelAsync(string channelId)
    {
        var channel = await _channelApi.GetChannelByIdAsync(channelId);
        return Ok(channel);
    }
    /// <summary>
    /// Creates channel.
    /// </summary>
    /// <param name="guildId"></param>
    /// <param name="request"></param>
    /// <returns>Created channel info.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateChannelAsync(string guildId, [FromBody] CreateChannelRequest request)
    {
        var channel = await _channelApi.CreateChannelAsync(guildId, request);
        return Ok(channel);
    }
    /// <summary>
    /// Updates channel by channel id.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Updated channel info.</returns>
    [HttpPatch]
    public async Task<IActionResult> UpdateChannelAsync([FromBody] UpdateChannelRequest request)
    {
        var channel = await _channelApi.UpdateChannelAsync(request.Id, request);
        return Ok(channel);
    }
    /// <summary>
    /// Deletes channel by id.
    /// </summary>
    /// <param name="channelId"></param>
    [HttpDelete]
    public async Task<IActionResult> DeleteChannelAsync(string channelId)
    {
        await _channelApi.DeleteChannelAsync(channelId);
        return NoContent();
    }
}