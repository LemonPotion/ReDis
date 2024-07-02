namespace Infrastructure.Dto_s.Channel.Responses;
/// <summary>
/// Create channel dto.
/// </summary>
public class CreateChannelResponse : BaseChannelDto
{
    /// <summary>
    /// Channel id.
    /// </summary>
    public string Id { get; init; }
}