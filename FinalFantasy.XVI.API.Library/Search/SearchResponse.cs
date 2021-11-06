namespace FinalFantasy.XIV.API.Models.Search;

public class SearchResponse<T> where T : class
{
	public Pagination pagination { get; set; } = new();

	public List<T>? Results { get; set; }

	public int SpeedMs { get; set; }
}
