using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Dto_s.Channel.Responses;
using Infrastructure.Dto_s.Guild;
using Infrastructure.Dto_s.Guild.Requests;
using Refit;

namespace Infrastructure.Interfaces;

public interface IGuildApi
{
    [Get("/users/@me/guilds")]
    Task<List<GetGuildResponse>> GetGuildsAsync([Header("Authorization")] string authorization);
    
    
    [Get("/guilds/{guildId}")]
    Task<GetGuildResponse> GetGuildByIdAsync([Header("Authorization")] string authorization, string guildId);
    
    
    [Delete("/guilds/{guildId}")]
    Task DeleteGuildAsync(string guildId, [Header("Authorization")] string authorization);

    [Patch("/guilds/{guildId}")]
    Task <UpdateGuildResponse> UpdateGuildAsync(string guildId, [Header("Authorization")] string authorization, [Body] UpdateGuildRequest request);

    [Post("/guilds")]
    Task<CreateChannelResponse> CreateGuildAsync([Body] CreateGuildRequest request,
        [Header("Authorization")] string authorization);
}