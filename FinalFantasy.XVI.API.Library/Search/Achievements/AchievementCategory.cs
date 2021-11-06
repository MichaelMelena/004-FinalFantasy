using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class AchievementCategory
{
	[JsonProperty("AchievementKind")]
	public AchievementKind? AchievementKind { get; set; }

	[JsonProperty("AchievementKindTarget")]
	public string? AchievementKindTarget { get; set; }

	[JsonProperty("AchievementKindTargetID")]
	public int? AchievementKindTargetID { get; set; }

	[JsonProperty("HideCategory")]
	public int? HideCategory { get; set; }

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

	[JsonProperty("ShowComplete")]
	public int? ShowComplete { get; set; }
}

