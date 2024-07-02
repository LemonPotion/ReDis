namespace Infrastructure.Dto_s.Channel.Responses;

/// <summary>
/// Update channel dto.
/// </summary>
public class UpdateChannelResponse : BaseChannelDto
{
    /// <summary>
    /// Channel id.
    /// </summary>
    public string Id { get; init; }
}