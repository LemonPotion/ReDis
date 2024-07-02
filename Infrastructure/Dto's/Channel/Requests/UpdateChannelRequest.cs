namespace Infrastructure.Dto_s.Channel.Requests;
/// <summary>
/// Update channel request dto.
/// </summary>
public class UpdateChannelRequest : BaseChannelDto
{
    /// <summary>
    /// Channel id.
    /// </summary>
    public string Id { get; init; }
}