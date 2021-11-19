using FFXIV.Models.Characters.Profiles;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Profiles;

public sealed class CharacterProfileParser : ParserBase, ICharacterProfileParser
{
	public (Race race, Clan clan, Gender gender) ParseCharacterBlock(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//p[@class='character-block__name']";
		HtmlNode? characterBlockNode = html?.SelectSingleNode(xPath);


		characterBlockNode = ReturnNotNullOrThrow(characterBlockNode, xPath);


		string[] clanAndGenderArray = characterBlockNode.ChildNodes[2].InnerText.Split('/');

		string raceText = characterBlockNode.ChildNodes[0].InnerText.Trim();
		string clanText = clanAndGenderArray[0].Trim();
		string genderSymbol = clanAndGenderArray[1].Trim();

		Race race = Enum.Parse<Race>(raceText);
		Clan clan = Enum.Parse<Clan>(clanText);
		Gender gender = string.Equals(genderSymbol, "♂", StringComparison.InvariantCulture) ? Gender.Male : Gender.Female;

		return (race, clan, gender);
	}

	public string ParseCityState(HtmlNode html)
	{
		throw new NotImplementedException();
	}

	public string ParseGrandComapny(HtmlNode html)
	{
		throw new NotImplementedException();
	}

	public string ParseName(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		HtmlNode? nameNode = html?.SelectSingleNode(".//p[@class='frame__chara__name']");
		ArgumentNullException.ThrowIfNull(nameNode);

		return nameNode.InnerText.Trim();
	}

	public string ParseNameDay(HtmlNode html)
	{
		throw new NotImplementedException();
	}

	public Profile ParseProfile(HtmlNode html)
	{
		throw new NotImplementedException();
	}

	public string ParseServer(HtmlNode html)
	{
		throw new NotImplementedException();
	}
}
