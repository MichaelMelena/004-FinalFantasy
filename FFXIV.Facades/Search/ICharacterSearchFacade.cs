using FFXIV.Models.Search;

namespace FFXIV.Facades.Search;

public interface ICharacterSearchFacade
{
	Task<List<CharacterSearchProfile>> GetSearchProfilesAsync(ProfileSearchRequest profileSearchRequest);
}