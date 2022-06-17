using System;
using FFXIV.Models.Extensions;
using FFXIV.Models.Search;
using FFXIV.Services.Lodestone.Http;
using FFXIV.Services.Parsers.CharacterSearch;
using Refit;
using HtmlAgilityPack;

namespace FFXIV.Facades.Search;

public class CharacterSearchFacade : ICharacterSearchFacade
{
	private readonly ILodestoneCharacterProfileApi lodestoneCharacterProfileApi;

	private readonly ICharacterSearchParser characterSearchParser;

	public CharacterSearchFacade(ILodestoneCharacterProfileApi lodestoneCharacterProfileApi, ICharacterSearchParser characterSearchParser)
	{
		this.lodestoneCharacterProfileApi = lodestoneCharacterProfileApi;
		this.characterSearchParser = characterSearchParser;
	}

	public async Task<List<CharacterSearchProfile>> GetSearchProfilesAsync(ProfileSearchRequest profileSearchRequest)
	{
		ArgumentNullException.ThrowIfNull(profileSearchRequest);
		ApiResponse<string> searchResponse = await lodestoneCharacterProfileApi.Search(profileSearchRequest.Name, profileSearchRequest.HomeWorld.GetDescription(), null, null, profileSearchRequest.Language.ToString());
		await searchResponse.EnsureSuccessStatusCodeAsync();
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(searchResponse.Content);


		List<CharacterSearchProfile> characterSearchProfiles = characterSearchParser.ParseSearchItems(htmlDocument.DocumentNode);
		return characterSearchProfiles;
	}
}
