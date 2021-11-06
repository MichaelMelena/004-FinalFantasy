using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class AchievementKind
{
	[JsonProperty("ID")]
	public int? ID { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("Order")]
	public int? Order { get; set; }
}

