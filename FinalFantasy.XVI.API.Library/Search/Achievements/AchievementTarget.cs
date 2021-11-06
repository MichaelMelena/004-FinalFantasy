using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class AchievementTarget
{
	[JsonProperty("ID")]
	public int? Id { get; set; }

	[JsonProperty("Type")]
	public int? Type { get; set; }

	[JsonProperty("Value")]
	public int? Value { get; set; }
}
