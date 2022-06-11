namespace FFXIV.Models.Search;

public record class Server
{
	public HomeWorld HomeWorld { get; init; }
	public DataCenter DataCenter { get; init; }
}

