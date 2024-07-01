using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Dto_s.Channel.Responses;
using Refit;

namespace Infrastructure.Interfaces;

public interface IChannelApi
{
    [Get("/guilds/{guildId}/channels")]
    Task<List<GetChannelResponse>> GetChannelsAsync([AliasAs("guildId")] string guildId);

    [Get("/channels/{channelId}")]
    Task<GetChannelResponse> GetChannelByIdAsync([AliasAs("channelId")] string channelId);

    [Post("/guilds/{guildId}/channels")]
    Task<CreateChannelResponse> CreateChannelAsync([AliasAs("guildId")] string guildId, [Body] CreateChannelRequest request);

    [Patch("/channels/{channelId}")]
    Task<UpdateChannelResponse> UpdateChannelAsync([AliasAs("channelId")] string channelId, [Body] UpdateChannelRequest request);

    [Delete("/channels/{channelId}")]
    Task DeleteChannelAsync([AliasAs("channelId")] string channelId);
}