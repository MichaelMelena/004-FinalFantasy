namespace FinalFantasy.XIV.API.Models.Character;

public class CharacterSearchResponse
{
	public Pagination Pagination { get; set; } = new();

	public List<Character> Results { get; set; } = new();
}
