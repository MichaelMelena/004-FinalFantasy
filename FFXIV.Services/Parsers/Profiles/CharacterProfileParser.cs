using System.Diagnostics.CodeAnalysis;
using FFXIV.Models.Characters.Profiles;
using FFXIV.Models.Extensions;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Profiles;

public sealed class CharacterProfileParser : ParserBase, ICharacterProfileParser
{
	public CityState ParseCityState(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//div[p='City-state']/p[last()]";
		HtmlNode? node = html?.SelectSingleNode(xPath);
		HtmlNode cityStateNode = ReturnNotNullOrThrow(node, xPath);

		string cityStateText = cityStateNode.InnerText;
		CityState cityState = ParseEnum<CityState>(cityStateText);

		return cityState;
	}

	public Clan ParseClan(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string[] genderAndClan = GetGenderAndClan(html);
		string clanText = genderAndClan[0].Trim();

		Clan clan = ParseEnum<Clan>(clanText);
		return clan;
	}

	public Gender ParseGender(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string[] genderAndClan = GetGenderAndClan(html);
		string genderSymbol = genderAndClan[1].Trim();

		Gender gender = genderSymbol switch
		{
			"♂" => Gender.Male,
			"♀" => Gender.Female,
			_ => throw new ArgumentOutOfRangeException(nameof(genderSymbol), "value is out of range: '♂' or '♀'")
		};

		return gender;
	}

	public GrandCompanyInfo ParseGrandComapny(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//div[p='Grand Company']/p[last()]";
		HtmlNode? node = html?.SelectSingleNode(xPath);
		HtmlNode grandCompanyInfoNode = ReturnNotNullOrThrow(node, xPath);

		string[] grandCompanyInfoArray = grandCompanyInfoNode.InnerText.Split("/");

		string grandCompanyText = grandCompanyInfoArray[0].Trim();
		string rankText = grandCompanyInfoArray[1].Trim();

		Dictionary<string, GrandCompany> descriptionToGrandCompanyDictionary = Enum.GetValues<GrandCompany>().ToDictionary(x => x.GetDescription()!, x => x);
		GrandCompany grandCompany = descriptionToGrandCompanyDictionary[grandCompanyText];

		Dictionary<GrandCompany, string> grandCompanyRankStrings = new Dictionary<GrandCompany, string>()
		{
			{ GrandCompany.ImmortalFlames, "Flame " },
			{ GrandCompany.OrderOfTheTwinAdder, "Serpent " },
			{ GrandCompany.Maelstrom, "Storm " },
			{ GrandCompany.NoAffiliation, string.Empty }
		};

		// if character has not joined grand company
		if (grandCompany is GrandCompany.NoAffiliation)
		{
			return new GrandCompanyInfo(grandCompany, GrandCompanyRank.NotInGrandCompany);
		}

		// remove grand company specific string from ranks
		string grandCompanyRankString = grandCompanyRankStrings[grandCompany];
		rankText = rankText.Replace(grandCompanyRankString, string.Empty);

		Dictionary<string, GrandCompanyRank> descriptionToRankDictionary = Enum.GetValues<GrandCompanyRank>().ToDictionary(x => x.GetDescription()!, x => x);
		GrandCompanyRank rank = descriptionToRankDictionary[rankText];

		return new GrandCompanyInfo(grandCompany, rank);
	}

	public string ParseName(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//p[@class='frame__chara__name']";
		HtmlNode? node = html?.SelectSingleNode(xPath);
		HtmlNode nameNode = ReturnNotNullOrThrow(node, xPath);

		string name = nameNode.InnerText.Trim();

		if (string.IsNullOrWhiteSpace(name))
		{
			throw new InvalidOperationException($"name: '{name}' is not valid");
		}

		return name;
	}

	public string ParseNameDay(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//p[@class='character-block__birth']";
		HtmlNode? node = html?.SelectSingleNode(xPath);
		HtmlNode nameDayNode = ReturnNotNullOrThrow(node, xPath);

		string nameDay = nameDayNode.InnerText;

		return nameDay;
	}

	public Profile ParseProfile(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string name = ParseName(html);
		string nameDay = ParseNameDay(html);
		string server = ParseServer(html);

		Gender gender = ParseGender(html);
		Clan clan = ParseClan(html);
		Race race = ParseRace(html);


		CityState cityState = ParseCityState(html);
		GrandCompanyInfo grandCompanyInfo = ParseGrandComapny(html);

		Profile profile = new Profile
		{
			Name = name,
			CityState = cityState,
			Clan = clan,
			Gender = gender,
			Race = race,
			GrandCompanyInfo = grandCompanyInfo,
			NameDay = nameDay,
			Server = server
		};

		return profile;
	}

	public Race ParseRace(HtmlNode html)
	{
		HtmlNode characteristicNode = GetCharacteristicNode(html);

		string raceText = characteristicNode.ChildNodes[0].InnerText.Trim();

		Race race = ParseEnum<Race>(raceText);
		return race;
	}

	public string ParseServer(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//p[@class='frame__chara__world']";

		HtmlNode? node = html.SelectSingleNode(xPath);
		HtmlNode serverNameNode = ReturnNotNullOrThrow(node, xPath);

		string serverName = serverNameNode.InnerText.Trim().Replace("&nbsp;", " ");

		return serverName;
	}

	private HtmlNode GetCharacteristicNode(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPath = ".//p[@class='character-block__name']";
		HtmlNode? characterBlockNode = html?.SelectSingleNode(xPath);
		return ReturnNotNullOrThrow(characterBlockNode, xPath);
	}

	private string[] GetGenderAndClan(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		HtmlNode characteristicNode = GetCharacteristicNode(html);
		return characteristicNode.ChildNodes[2].InnerText.Split('/');
	}

	private TEnum ParseEnum<TEnum>([NotNull] string text) where TEnum : struct, Enum
	{
		ArgumentNullException.ThrowIfNull(text);

		bool hasParsed = Enum.TryParse(text, out TEnum result);

		if (!hasParsed)
		{
			throw new ArgumentOutOfRangeException(nameof(text), $"value is out of range: {string.Join(", ", Enum.GetNames<TEnum>())}");
		}

		return result;
	}
}
