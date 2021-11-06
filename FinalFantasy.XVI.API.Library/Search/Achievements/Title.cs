using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class Title
{
	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Icon")]
	public string? Icon { get; set; }

	[JsonProperty("IsPrefix")]
	public int IsPrefix { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("NameFemale")]
	public string? NameFemale { get; set; }

	[JsonProperty("NameFemale_de")]
	public string? NameFemaleDe { get; set; }

	[JsonProperty("NameFemale_en")]
	public string? NameFemaleEn { get; set; }

	[JsonProperty("NameFemale_fr")]
	public string? NameFemaleFr { get; set; }

	[JsonProperty("NameFemale_ja")]
	public string? NameFemaleJa { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("Order")]
	public int Order { get; set; }
}
