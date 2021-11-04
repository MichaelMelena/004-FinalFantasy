using FinalFantasy.XIV.API.Models.Character;
using Refit;

namespace FinalFantasy.XIV.API.Services.Character;

public interface ICharacterApiRefit
{
	[Get("/character/search")]
	Task<CharacterSearchResponse> SearchAsync([AliasAs("private_key")] string privateKey, string name, string? server, string? page);
}
