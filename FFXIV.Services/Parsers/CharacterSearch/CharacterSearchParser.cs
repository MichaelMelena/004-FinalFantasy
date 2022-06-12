using FFXIV.Models.Search;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.CharacterSearch;

public sealed class CharacterSearchParser : ICharacterSearchParser
{
	/// <summary>
	/// Parses character name from search profile
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns>name</returns>
	private string ParseName(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);
		string xPath = "//p[@class=\"entry__name\"]";

		HtmlNode? characterNameNode = entryNode.SelectSingleNode(xPath);
		characterNameNode = characterNameNode.EnsureNotNull(xPath);

		string characterName = characterNameNode.InnerText;
		return characterName;
	}

	/// <summary>
	/// Parses server from search profile
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns>Search profile server/returns>
	private Server ParseServer(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);
		string xPath = "//p[@class=\"entry__world\"]";

		HtmlNode? worldNode = entryNode.SelectSingleNode(xPath);
		worldNode = worldNode.EnsureNotNull(xPath);

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

	/// <summary>
	/// Parses character search profile language
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns>language</returns>
	private Language ParseLanuage(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);
		string xPath = "//div[@class=\"entry__chara__lang\"]";

		HtmlNode? languageNode = entryNode.SelectSingleNode(xPath);
		languageNode = languageNode.EnsureNotNull(xPath);

		string languageString = languageNode.InnerText;
		Language language = Enum.Parse<Language>(languageString, true);

		return language;
	}

	/// <summary>
	/// Parses relative <see cref="Uri"/> for character search profile portrait
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns></returns>
	private Uri ParsePortraitUri(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);
		string xPath = "//div[@class=\"entry__chara__face\"]/img";

		HtmlNode? characterPortraiNode = entryNode.SelectSingleNode(xPath);
		characterPortraiNode = characterPortraiNode.EnsureNotNull(xPath);

		string portraitLink = characterPortraiNode.GetAttributeValue("src", null);
		return new Uri(portraitLink);
	}

	/// <summary>
	/// Parses relative Uri for character main profile from search profile
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns>relative uri for character main profile</returns>
	private Uri ParseCharacterLink(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);
		string xPath = "//a[@class=\"entry__link\"]";

		HtmlNode? characterLinkNode = entryNode.SelectSingleNode(xPath);
		characterLinkNode = characterLinkNode.EnsureNotNull(xPath);

		string characterLink = characterLinkNode.GetAttributeValue("href", null);
		return new Uri(characterLink);
	}

	/// <summary>
	/// Parse single search item profile
	/// </summary>
	/// <param name="entryNode"></param>
	/// <returns></returns>
	public CharacterSearchProfile ParseSearchItem(HtmlNode entryNode)
	{
		ArgumentNullException.ThrowIfNull(entryNode);

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

	/// <summary>
	/// Parse all search item profiles
	/// </summary>
	/// <param name="node"></param>
	/// <returns>Collection of parsed search profiles</returns>
	public List<CharacterSearchProfile> ParseSearchItems(HtmlNode node)
	{
		ArgumentNullException.ThrowIfNull(node);

		HtmlNodeCollection? entryNodes = node.SelectNodes("//*[@class=\"entry\"]");
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
