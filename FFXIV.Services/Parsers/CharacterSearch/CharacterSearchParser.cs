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

		HomeWorld homeWorld = Enum.Parse<HomeWorld>(worldString, true);
		DataCenter dataCenter = Enum.Parse<DataCenter>(dataCenterString, true);

		return new Server
		{
			DataCenter = dataCenter,
			HomeWorld = homeWorld
		};

	}

	private Language ParseLanuage(HtmlNode entryNode)
	{
		HtmlNode languageNode = entryNode.SelectSingleNode("//div[@class=\"entry__chara__lang\"]");
		string languageString = languageNode.InnerText;
		Language language = Enum.Parse<Language>(languageString, true);
		return language;
	}

	private Uri ParsePortraitUri(HtmlNode entryNode)
	{
		HtmlNode characterPortraiNode = entryNode.SelectSingleNode("//div[@class=\"entry__chara__face\"]/img");
		string portraitLink = characterPortraiNode.GetAttributeValue("src", null);
		return new Uri(portraitLink);
	}

	private Uri ParseCharacterLink(HtmlNode entryNode)
	{
		HtmlNode characterLinkNode = entryNode.SelectSingleNode("//a[@class=\"entry__link\"]");
		string characterLink = characterLinkNode.GetAttributeValue("href", null);
		return new Uri(characterLink);
	}

	public CharacterSearchProfile ParseSearchItem(HtmlNode entryNode)
	{
		string characterName = ParseName(entryNode);
		Server server = ParseServer(entryNode);
		Language language = ParseLanuage(entryNode);
		Uri characterLink = ParseCharacterLink(entryNode);
		Uri characterPortraitUri = ParsePortraitUri(entryNode);

		return new CharacterSearchProfile
		{
			Name = characterName,
			Server = server,
			Language = language,
			CharacterUri = characterLink,
			PortraitUri = characterPortraitUri
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
