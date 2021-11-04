using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.GameData.Servers;

public class ServersByDataCenterResponse
{
	public List<string> Aether { get; set; } = new();

	public List<string> Chaos { get; set; } = new();
	
	public List<string> Crystal { get; set; } = new();
	
	public List<string> Elemental { get; set; } = new();
	
	public List<string> Gaia { get; set; } = new();
	
	public List<string> Korea { get; set; } = new();

	public List<string> Light { get; set; } = new();

	public List<string> Mana { get; set; } = new();

	public List<string> Primal { get; set; } = new();

	[JsonProperty("猫小胖")]
	public List<string> Carbuncle { get; set; } = new();

	[JsonProperty("莫古力")]
	public List<string> Moogle { get; set; } = new();

	[JsonProperty("陆行鸟")]
	public List<string> Chocobo { get; set; } = new();
}
