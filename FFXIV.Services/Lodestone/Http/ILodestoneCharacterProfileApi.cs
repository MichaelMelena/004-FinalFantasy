using Refit;

namespace FFXIV.Services.Lodestone.Http;

public interface ILodestoneCharacterProfileApi
{
	[Get("/lodestone/character/{id}/")]
	Task<ApiResponse<string>> GetCharacterAsync([AliasAs("id")]string userId);

	[Get("/lodestone/character/{id}/quest/")]
	Task<ApiResponse<string>> GetQuestsAsync([AliasAs("id")]string userId,int page);
}
