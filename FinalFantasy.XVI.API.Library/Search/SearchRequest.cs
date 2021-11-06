using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search;

public class SearchRequest<T> where T : class, new()
{
	[JsonProperty("indexes")] public string Indexes { get; set; } = "achievements";

	[JsonProperty("columns")] public string Columns { get; set; } = "*";

	[JsonProperty("body")] public T Body { get; set; } = new();
}
