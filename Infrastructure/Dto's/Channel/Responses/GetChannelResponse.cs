namespace Infrastructure.Dto_s.Channel.Responses;

/// <summary>
/// Get channel dto.
/// </summary>
public class GetChannelResponse : BaseChannelDto
{
    /// <summary>
    /// Channel id.
    /// </summary>
    public string Id { get; init; }
}