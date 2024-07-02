namespace Infrastructure.Dto_s.Guild.Requests;
/// <summary>
/// Update guild dto.
/// </summary>
public class UpdateGuildRequest : BaseGuildDto
{
    /// <summary>
    /// Guild id.
    /// </summary>
    public string Id { get; init; }
}