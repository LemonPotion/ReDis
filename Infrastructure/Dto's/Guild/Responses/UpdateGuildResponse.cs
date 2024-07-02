namespace Infrastructure.Dto_s.Guild.Responses;
/// <summary>
/// Update guild dto.
/// </summary>
public class UpdateGuildResponse : BaseGuildDto
{
    /// <summary>
    /// Guild id.
    /// </summary>
    public string Id { get; init; }
}