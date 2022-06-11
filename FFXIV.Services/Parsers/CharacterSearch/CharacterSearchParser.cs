using FFXIV.Models.Search;
using FFXIV.Services.Lodestone.Http;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.CharacterSearch;

public sealed class CharacterSearchParser
{

	private string ParseName(HtmlNode entryNode)
	{
		HtmlNode characterNameNode = entryNode.SelectSingleNode("//p[@class=\"entry__name\"]");
		string characterName = characterNameNode.InnerText;
		return characterName;
	}

	private Server ParseServer(HtmlNode entryNode)
	{
		HtmlNode worldNode = entryNode.SelectSingleNode("//p[@class=\"entry__world\"]");
		string worldAndDataCenterText = worldNode.InnerText;

		string[] parts = worldAndDataCenterText.Split("[");
		string worldString = parts[0].Trim();
		string dataCenterString = parts[1].Substring(0, parts[1].Length - 1);

		HomeWorld homeWorld = Enum.Parse<HomeWorld>(worldString);
		DataCenter dataCenter = Enum.Parse<DataCenter>(dataCenterString);

		return new Server
		{
			DataCenter = dataCenter,
			HomeWorld = homeWorld
		};

	}

	private Language ParseLanuage(HtmlNode entryNode)
	{
		HtmlNode languageNode = entryNode.SelectSingleNode("p[@class=\"entry__chara__lang\"]");
		throw new NotImplementedException();
	}

	private Uri ParsePortraitUri(HtmlNode entryNode)
	{
		throw new NotImplementedException();
	}

	private Uri ParseCharacterLink(HtmlNode entryNode)
	{
		throw new NotImplementedException();
	}

	public CharacterSearchProfile ParseSearchItem(HtmlNode entryNode)
	{
		string characterName = ParseName(entryNode);
		Server server = ParseServer(entryNode);
		Language language = ParseLanuage(entryNode);
		HtmlNode characterLinkNode = entryNode.SelectSingleNode("a[@class=\"entry__link\"]");

		return new CharacterSearchProfile
		{
			Name = characterName,
			Server = server
		};
	}

	public List<CharacterSearchProfile> ParseSearchItems(HtmlNode? node)
	{
		HtmlNodeCollection? entryNodes = node?.SelectNodes("//*[@class=\"entry\"]");
		List<CharacterSearchProfile> characterSearchProfiles = new List<CharacterSearchProfile>();

		if (entryNodes is null)
		{
			return characterSearchProfiles;
		}

		foreach (HtmlNode entryNode in entryNodes)
		{
			CharacterSearchProfile characterSearchProfile = ParseSearchItem(entryNode);
			if (entryNode is not null)
			{
				characterSearchProfiles.Add(characterSearchProfile);
			}
		}

		return characterSearchProfiles;
	}
}
