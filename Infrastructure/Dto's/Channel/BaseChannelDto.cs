namespace Infrastructure.Dto_s.Channel;
/// <summary>
/// Base channel Dto.
/// </summary>
public class BaseChannelDto
{
    /// <summary>
    /// Channel name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Channel type.
    /// </summary>
    public int Type { get; set; }
}