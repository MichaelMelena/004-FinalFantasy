using FFXIV.Models.Characters.Profiles;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Profiles;

public interface ICharacterProfileParser: IParser<CharacterProfile>
{
	string ParseName(HtmlNode html);

	CityState ParseCityState(HtmlNode html);

	string ParseNameDay(HtmlNode html);

	GrandCompanyInfo ParseGrandComapny(HtmlNode html);

	CharacterProfile ParseProfile(HtmlNode html);

	string ParseServer(HtmlNode html);

	Race ParseRace(HtmlNode html);

	Clan ParseClan(HtmlNode html);

	Gender ParseGender(HtmlNode html);
}
