namespace Infrastructure.Dto_s.Guild;
/// <summary>
/// Base guild dto.
/// </summary>
public class BaseGuildDto
{
    /// <summary>
    /// Guild name.
    /// </summary>
    public string Name { get; init; }
    /// <summary>
    /// Guild icon.
    /// </summary>
    public string? Icon { get; init; }
}