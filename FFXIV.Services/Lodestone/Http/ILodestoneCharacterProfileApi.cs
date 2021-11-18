using Refit;

namespace FFXIV.Services.Lodestone.Http;

public interface ILodestoneCharacterProfileApi
{
	[Get("/lodestone/character/{id}/")]
	Task<ApiResponse<string>> GetCharacterAsync([AliasAs("id")]string userId);
}
