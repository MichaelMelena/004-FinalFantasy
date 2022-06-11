namespace FFXIV.Models.Search;

public record class CharacterSearchProfile
{
	public Server Server { get; init; } = new Server();
	public Language Language { get; init; }
	public string Name { get; init; } = string.Empty;
	public Uri? CharacterUri { get; init; }
	public Uri? PortraitUri { get; init; }
}

