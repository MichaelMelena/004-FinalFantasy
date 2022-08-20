using FFXIV.Models.Characters.Profiles;
using FFXIV.Services.Lodestone.Http;
using FFXIV.Services.Parsers.Profiles;
using HtmlAgilityPack;
using Refit;

namespace FFXIV.Services.Tests.Integration;

[TestClass]
public class ProfileParseIntegrationTests
{
	private const string Id = "28632101";

	private static ILodestoneCharacterProfileApi? _api;

	private ICharacterProfileParser ProfileParser { get; } = new CharacterProfileParser();

	private static readonly HtmlDocument Html = new HtmlDocument();


	[ClassInitialize]
	public static void ClassInitialize(TestContext context)
	{
		_api = RestService.For<ILodestoneCharacterProfileApi>("https://eu.finalfantasyxiv.com");
		Task<ApiResponse<string>> task = _api.GetCharacterAsync(Id);
		task.Wait();
		ApiResponse<string> response = task.Result;
		Html.LoadHtml(response.Content);
	}

	[TestMethod]
	public void ParseNameTest()
	{
		string name = ProfileParser.ParseName(Html.DocumentNode);
		name.Should().NotBeNullOrWhiteSpace();
		name.Should().BeEquivalentTo("Elseif Machina");
	}

	[TestMethod]
	public void ParseRace_Test()
	{
		// act
		Race race = ProfileParser.ParseRace(Html.DocumentNode);

		// assert
		race.Should().Be(Race.Roegadyn, "Character in the html has this race");
	}

	[TestMethod]
	public void ParseClan_Test()
	{
		// assert
		Clan clan = ProfileParser.ParseClan(Html.DocumentNode);

		// act
		clan.Should().Be(Clan.Hellsguard, "it is the characters clan in HTML");
	}

	[TestMethod]
	public void ParseGender_Test()
	{
		// assert
		Gender gender = ProfileParser.ParseGender(Html.DocumentNode);

		// act
		gender.Should().Be(Gender.Male, "it is the characters gender in HTML");
	}

	[TestMethod]
	public void ParseNameDay_Test()
	{
		// assert
		string nameDay = ProfileParser.ParseNameDay(Html.DocumentNode);

		// act
		nameDay.Should().BeEquivalentTo("13th Sun of the 3rd Astral Moon", "It's the name day character has in HTML");
	}

	[TestMethod]
	public void ParseCityState_Test()
	{
		// assert
		CityState cityState = ProfileParser.ParseCityState(Html.DocumentNode);

		// act
		cityState.Should().Be(CityState.Gridania, "It's the city state character has in HTML");
	}

	[TestMethod]
	public void ParseServer_Test()
	{
		// act
		string serverName = ProfileParser.ParseServer(Html.DocumentNode);

		// assert
		serverName.Should().NotBeNullOrWhiteSpace().And.BeEquivalentTo("Twintania [Light]");
	}
	[TestMethod]
	public void ParseGrandComapny_Test()
	{
		// act
		GrandCompanyInfo grandCompanyInfo = ProfileParser.ParseGrandComapny(Html.DocumentNode);

		// assert
		grandCompanyInfo.Should().NotBeNull();

		grandCompanyInfo.GrandCompany.Should().Be(GrandCompany.ImmortalFlames);
		grandCompanyInfo.Rank.Should().BeOneOf(GrandCompanyRank.FirstLieutenant);
	}

	[TestMethod]
	public void ParseProfile_Test()
	{
		// act
		CharacterProfile profile = ProfileParser.ParseProfile(Html.DocumentNode);

		// assert
		profile.Should().NotBeNull();

		profile.CityState.Should().Be(CityState.Gridania);
		profile.Clan.Should().Be(Clan.Hellsguard);
		profile.Gender.Should().Be(Gender.Male);
		profile.Name.Should().Be("Elseif Machina");
		profile.NameDay.Should().Be("13th Sun of the 3rd Astral Moon");
		profile.Server.Should().Be("Twintania [Light]");
		profile.Race.Should().Be(Race.Roegadyn);
		profile.GrandCompanyInfo.Should().Be(new GrandCompanyInfo(GrandCompany.ImmortalFlames, GrandCompanyRank.FirstLieutenant));

	}
}
