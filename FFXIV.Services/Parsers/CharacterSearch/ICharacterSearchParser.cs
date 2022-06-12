using FFXIV.Models.Search;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.CharacterSearch;

public interface ICharacterSearchParser
{
	CharacterSearchProfile ParseSearchItem(HtmlNode entryNode);
	List<CharacterSearchProfile> ParseSearchItems(HtmlNode node);
}