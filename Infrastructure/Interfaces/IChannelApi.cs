using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Dto_s.Channel.Responses;
using Refit;

namespace Infrastructure.Interfaces;
/// <summary>
/// Discord channel api refit interface.
/// </summary>
public interface IChannelApi
{
    /// <summary>
    /// Gets channels list by guild id.
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns>All channels info.</returns>
    [Get("/guilds/{guildId}/channels")]
    Task<List<GetChannelResponse>> GetChannelsAsync([AliasAs("guildId")] string guildId);
    /// <summary>
    /// Gets channel.
    /// </summary>
    /// <param name="channelId"></param>
    /// <returns>Channel info.</returns>
    [Get("/channels/{channelId}")]
    Task<GetChannelResponse> GetChannelByIdAsync([AliasAs("channelId")] string channelId);
    /// <summary>
    /// Creates channel.
    /// </summary>
    /// <param name="guildId"></param>
    /// <param name="request"></param>
    /// <returns>Created channel info.</returns>
    [Post("/guilds/{guildId}/channels")]
    Task<CreateChannelResponse> CreateChannelAsync([AliasAs("guildId")] string guildId, [Body] CreateChannelRequest request);
    /// <summary>
    /// Updates channel info.
    /// </summary>
    /// <param name="channelId"></param>
    /// <param name="request"></param>
    /// <returns>Updated channel info.</returns>
    [Patch("/channels/{channelId}")]
    Task<UpdateChannelResponse> UpdateChannelAsync([AliasAs("channelId")] string channelId, [Body] UpdateChannelRequest request);
    /// <summary>
    /// Deletes channel by id.
    /// </summary>
    /// <param name="channelId"></param>
    [Delete("/channels/{channelId}")]
    Task DeleteChannelAsync([AliasAs("channelId")] string channelId);
}