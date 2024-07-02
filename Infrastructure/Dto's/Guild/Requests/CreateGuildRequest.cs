namespace Infrastructure.Dto_s.Guild.Requests;
/// <summary>
/// Create Guild dto.
/// </summary>
public class CreateGuildRequest : BaseGuildDto
{
    /// <summary>
    /// Discord guild template code.
    /// </summary>
    public string? GuildTemplateCode { get; init; }
}   