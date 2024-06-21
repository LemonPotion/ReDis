using Infrastructure.Dto_s.Guild;
using Refit;

namespace Infrastructure.Interfaces;

public interface IGuildApi
{
    [Get("/users/@me/guilds")]
    Task<List<GetAllGuildsResponse>> GetGuildsAsync([Header("Authorization")] string authorization);
    
    //401 Unauthorized
    [Get("/guilds/{guildId}")]
    Task<string> GetGuildByIdAsync([Header("Authorization")] string authorization, string guildId);

    [Delete("/guilds/{guildId}")]
    Task DeleteGuildAsync(string guildId, [Header("Authorization")] string authorization);
}