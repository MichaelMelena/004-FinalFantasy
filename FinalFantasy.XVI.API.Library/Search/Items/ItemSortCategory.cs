using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

public class ItemSortCategory
{
	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Param")]
	public int Param { get; set; }
}



