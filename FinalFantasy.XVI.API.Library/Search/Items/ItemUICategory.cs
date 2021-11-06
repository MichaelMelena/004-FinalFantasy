using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

public class ItemUICategory
{
	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Icon")]
	public string? Icon { get; set; }

	[JsonProperty("IconHD")]
	public string? IconHD { get; set; }

	[JsonProperty("IconID")]
	public int IconID { get; set; }

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

	[JsonProperty("OrderMajor")]
	public int OrderMajor { get; set; }

	[JsonProperty("OrderMinor")]
	public int OrderMinor { get; set; }
}



