using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Character;

public class Character
{
	public Uri? Avatar { get; set; }

	public int FeastMatches { get; set; }

	[JsonProperty("ID")]
	public int Id { get; set; }

	public string? Lang { get; set; }

	public string Name { get; set; } = string.Empty;

	public string? Rank { get; set; }

	public Uri? RankIcon { get; set; }

	public string Server { get; set; } = string.Empty;

}
