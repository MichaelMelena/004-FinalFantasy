using FFXIV.Models.Characters.Profiles;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Profiles;

public  interface ICharacterProfileParser
{
	string ParseName(HtmlNode html);

	(Race race, Clan clan, Gender gender) ParseCharacterBlock(HtmlNode html);

	string ParseCityState(HtmlNode html);

	string ParseNameDay(HtmlNode html);

	string ParseGrandComapny(HtmlNode html);

	Profile ParseProfile(HtmlNode html);

	string ParseServer(HtmlNode html);
}
