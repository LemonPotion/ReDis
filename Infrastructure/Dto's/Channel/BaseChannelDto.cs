namespace Infrastructure.Dto_s.Channel;

public class BaseChannelDto
{
    public string Name { get; set; }
    public int Type { get; set; }
    public int Position { get; set; }
    public bool IsNSFW { get; set; }
}