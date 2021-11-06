using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

public class EquipSlotCategory
{
	[JsonProperty("Body")]
	public int Body { get; set; }

	[JsonProperty("Ears")]
	public int Ears { get; set; }

	[JsonProperty("Feet")]
	public int Feet { get; set; }

	[JsonProperty("FingerL")]
	public int FingerL { get; set; }

	[JsonProperty("FingerR")]
	public int FingerR { get; set; }

	[JsonProperty("Gloves")]
	public int Gloves { get; set; }

	[JsonProperty("Head")]
	public int Head { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Legs")]
	public int Legs { get; set; }

	[JsonProperty("MainHand")]
	public int MainHand { get; set; }

	[JsonProperty("Neck")]
	public int Neck { get; set; }

	[JsonProperty("OffHand")]
	public int OffHand { get; set; }

	[JsonProperty("SoulCrystal")]
	public int SoulCrystal { get; set; }

	[JsonProperty("Waist")]
	public int Waist { get; set; }

	[JsonProperty("Wrists")]
	public int Wrists { get; set; }
}



