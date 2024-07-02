using Infrastructure.Dto_s.Channel.Requests;
using Infrastructure.Dto_s.Channel.Responses;
using Infrastructure.Dto_s.Guild;
using Infrastructure.Dto_s.Guild.Requests;
using Infrastructure.Dto_s.Guild.Responses;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Infrastructure.Interfaces;
/// <summary>
/// Discord Guild Api Refit interface.
/// </summary>
public interface IGuildApi
{
    /// <summary>
    /// Gets current user guilds.
    /// </summary>
    /// <returns>All current user guilds.</returns>
    [Get("/users/@me/guilds")]
    Task<List<GetGuildResponse>> GetGuildsAsync();
    
    /// <summary>
    /// Gets guild by id.
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns>Guild info.</returns>
    [Get("/guilds/{guildId}")]
    Task<GetGuildResponse> GetGuildByIdAsync(string guildId);
    
    /// <summary>
    /// Leave guild by guild id.
    /// </summary>
    /// <param name="guildId"></param>
    [Delete("/guilds/{guildId}")]
    Task DeleteGuildAsync(string guildId);

    /// <summary>
    /// Updates guilds info.
    /// </summary>
    /// <param name="guildId"></param>
    /// <param name="request"></param>
    /// <returns>Updated guild info.</returns>
    [Patch("/guilds/{guildId}")]
    Task<UpdateGuildResponse> UpdateGuildAsync(string guildId, [Body] UpdateGuildRequest request);
    /// <summary>
    /// Creates discord guild.
    /// </summary>
    /// <param name="request"></param>
    /// <returns>Created guild info.</returns>
    [Post("/guilds")]
    public Task<CreateGuildResponse> CreateGuildAsync(
        [FromBody] CreateGuildRequest request);
}