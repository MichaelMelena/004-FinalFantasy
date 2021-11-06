using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class GamePatch
{
	[JsonProperty("Banner")]
	public string? Banner { get; set; }

	[JsonProperty("ExName")]
	public string? ExName { get; set; }

	[JsonProperty("ExVersion")]
	public int? ExVersion { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("Name_cn")]
	public string? NameCn { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("Name_kr")]
	public string? NameKr { get; set; }

	[JsonProperty("ReleaseDate")]
	public int ReleaseDate { get; set; }

	[JsonProperty("Version")]
	public string? Version { get; set; }
}

