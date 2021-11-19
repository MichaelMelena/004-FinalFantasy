using FFXIV.Models.Characters.Profiles;

namespace FFXIV.Services.Lodestone;

public interface ICharacterProfileParser
{
	Task<Profile> GetProfileAsync(string id);
}
