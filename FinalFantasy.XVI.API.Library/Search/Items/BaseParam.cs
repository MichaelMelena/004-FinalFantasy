using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class BaseParam
{
	[JsonProperty("1HWpn%")]
	public int _1HWpn { get; set; }

	[JsonProperty("2HWpn%")]
	public int _2HWpn { get; set; }

	[JsonProperty("Bracelet%")]
	public int Bracelet { get; set; }

	[JsonProperty("Chest%")]
	public int Chest { get; set; }

	[JsonProperty("ChestHead%")]
	public int ChestHead { get; set; }

	[JsonProperty("ChestHeadLegsFeet%")]
	public int ChestHeadLegsFeet { get; set; }

	[JsonProperty("ChestLegsFeet%")]
	public int ChestLegsFeet { get; set; }

	[JsonProperty("ChestLegsGloves%")]
	public int ChestLegsGloves { get; set; }

	[JsonProperty("Description")]
	public string? Description { get; set; }

	[JsonProperty("Description_de")]
	public string? DescriptionDe { get; set; }

	[JsonProperty("Description_en")]
	public string? DescriptionEn { get; set; }

	[JsonProperty("Description_fr")]
	public string? DescriptionFr { get; set; }

	[JsonProperty("Description_ja")]
	public string? DescriptionJa { get; set; }

	[JsonProperty("Earring%")]
	public int Earring { get; set; }

	[JsonProperty("Feet%")]
	public int Feet { get; set; }

	[JsonProperty("Hands%")]
	public int Hands { get; set; }

	[JsonProperty("Head%")]
	public int Head { get; set; }

	[JsonProperty("HeadChestHandsLegsFeet%")]
	public int HeadChestHandsLegsFeet { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Legs%")]
	public int Legs { get; set; }

	[JsonProperty("LegsFeet%")]
	public int LegsFeet { get; set; }

	[JsonProperty("MeldParam0")]
	public int MeldParam0 { get; set; }

	[JsonProperty("MeldParam1")]
	public int MeldParam1 { get; set; }

	[JsonProperty("MeldParam10")]
	public int MeldParam10 { get; set; }

	[JsonProperty("MeldParam11")]
	public int MeldParam11 { get; set; }

	[JsonProperty("MeldParam12")]
	public int MeldParam12 { get; set; }

	[JsonProperty("MeldParam2")]
	public int MeldParam2 { get; set; }

	[JsonProperty("MeldParam3")]
	public int MeldParam3 { get; set; }

	[JsonProperty("MeldParam4")]
	public int MeldParam4 { get; set; }

	[JsonProperty("MeldParam5")]
	public int MeldParam5 { get; set; }

	[JsonProperty("MeldParam6")]
	public int MeldParam6 { get; set; }

	[JsonProperty("MeldParam7")]
	public int MeldParam7 { get; set; }

	[JsonProperty("MeldParam8")]
	public int MeldParam8 { get; set; }

	[JsonProperty("MeldParam9")]
	public int MeldParam9 { get; set; }

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

	[JsonProperty("Necklace%")]
	public int Necklace { get; set; }

	[JsonProperty("OH%")]
	public int OH { get; set; }

	[JsonProperty("OrderPriority")]
	public int OrderPriority { get; set; }

	[JsonProperty("PacketIndex")]
	public string? PacketIndex { get; set; }

	[JsonProperty("Ring%")]
	public int Ring { get; set; }

	[JsonProperty("UnderArmor%")]
	public int UnderArmor { get; set; }

	[JsonProperty("Waist%")]
	public int Waist { get; set; }
}



