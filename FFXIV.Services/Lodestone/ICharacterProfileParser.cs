using FFXIV.Services.Lodestone.Models;

namespace FFXIV.Services.Lodestone;

public interface ICharacterProfileParser
{
	Task<Profile> GetProfileAsync(string id);
}
