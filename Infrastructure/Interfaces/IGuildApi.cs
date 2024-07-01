using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Dto_s.Channel.Responses;
using Infrastructure.Dto_s.Guild;
using Infrastructure.Dto_s.Guild.Requests;
using Refit;

namespace Infrastructure.Interfaces;

public interface IGuildApi
{
    [Get("/users/@me/guilds")]
    Task<List<GetGuildResponse>> GetGuildsAsync();
    
    
    [Get("/guilds/{guildId}")]
    Task<GetGuildResponse> GetGuildByIdAsync( string guildId);
    
    
    [Delete("/guilds/{guildId}")]
    Task DeleteGuildAsync(string guildId);

    [Patch("/guilds/{guildId}")]
    Task <UpdateGuildResponse> UpdateGuildAsync(string guildId, [Body] UpdateGuildRequest request);

    [Post("/guilds")]
    Task<CreateChannelResponse> CreateGuildAsync([Body] CreateGuildRequest request);
}