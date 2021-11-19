using FFXIV.Services.Lodestone.Http;
using Refit;
using HtmlAgilityPack;
using FFXIV.Models.Characters.Profiles;

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
		ApiResponse<string> response = await lodestoneCharacterProfileApi.GetCharacterAsync(id);
		if (!response.IsSuccessStatusCode)
		{
			//response.Error.StatusCode
			// TODO: Handle error
		}
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(response.Content);

		//TODO: Do the parsing
		HtmlNode characterDiv = htmlDocument.GetElementbyId("character");

		var name = ParseName(characterDiv);
		(Race race, Clan clan, Gender gender) = ParseCharacterBlock(characterDiv);


		//var profile = new Profile(name,);

		return null;
	}


	private HtmlNode SelectNameNode(HtmlNode characterDiv)
	{
		var nameDiv = characterDiv.SelectSingleNode(".//p[@class='frame__chara__name']");
		return nameDiv;
	}

	private string ParseName(HtmlNode characterDiv)
	{
		HtmlNode nameNode = SelectNameNode(characterDiv);
		return nameNode.InnerText.Trim();
	}

	private HtmlNode SelectCharacterBlockNode(HtmlNode characterDiv)
	{
		var characterBlockNode = characterDiv.SelectSingleNode(".//p[@class='character-block__name']");
		return characterBlockNode;
	}

	private (Race, Clan, Gender) ParseCharacterBlock(HtmlNode characterDiv)
	{
		HtmlNode characterBlockNode = SelectCharacterBlockNode(characterDiv);

		string[] clanAndGenderArray = characterBlockNode.ChildNodes[2].InnerText.Split('/');

		string raceText = characterBlockNode.ChildNodes[0].InnerText.Trim();
		string clanText = clanAndGenderArray[0].Trim();
		string genderSymbol = clanAndGenderArray[1].Trim();

		Race race = Enum.Parse<Race>(raceText);
		Clan clan = Enum.Parse<Clan>(clanText);
		Gender gender = string.Equals(genderSymbol, "♂", StringComparison.InvariantCulture) ? Gender.Male : Gender.Female;


		return (race, clan, gender);
	}

}
