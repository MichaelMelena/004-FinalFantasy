using FFXIV.Services.Lodestone.Http;
using FFXIV.Services.Lodestone.Models;
using Refit;
using HtmlAgilityPack;
namespace FFXIV.Services.Lodestone;

public class CharacterProfileParser : ICharacterProfileParser
{
	private readonly ILodestoneCharacterProfileApi lodestoneCharacterProfileApi;

	public CharacterProfileParser(ILodestoneCharacterProfileApi lodestoneCharacterProfileApi)
	{
		this.lodestoneCharacterProfileApi = lodestoneCharacterProfileApi;
	}

	public async Task<Profile> GetProfileAsync(string id)
	{
		ApiResponse<string> response =  await lodestoneCharacterProfileApi.GetCharacterAsync(id);
		if (!response.IsSuccessStatusCode)
		{
			//response.Error.StatusCode
			// TODO: Handle error
		}
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(response.Content);

		//TODO: Do the parsing
		HtmlNode characterDiv = htmlDocument.GetElementbyId("character");
		var frameCharacter = characterDiv.ChildNodes.First(x => x.HasClass("frame__chara"));
		var frameCharacterLink = frameCharacter.ChildNodes.First(x => x.HasClass("frame__chara__link"));
		var frameCharacterBox = frameCharacterLink.ChildNodes.First(x => x.HasClass("frame__chara__box"));
		var frameCharacterName = frameCharacterBox.ChildNodes.First(x => x.HasClass("frame__chara__name"));
		string name = frameCharacterName.InnerText;

		var profile = new Profile(name);
		
		return profile;
	}
}
