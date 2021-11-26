using FFXIV.Models.Characters.Profiles;
using FFXIV.Services.Parsers.Profiles;
using HtmlAgilityPack;

namespace FFXIV.Services.Tests.Lodestone;

[TestClass]
public class LodesStoneProfileParsingTests
{
	private ICharacterProfileParser ProfileParser { get; } = new CharacterProfileParser();

	private HtmlDocument ProfileHtml { get; } = new HtmlDocument();

	private HtmlDocument InvalidHtml { get; } = new HtmlDocument();

	private HtmlDocument InvalidRaceClanGenderHtml { get; } = new HtmlDocument();


	public LodesStoneProfileParsingTests()
	{
		InvalidHtml.LoadHtml("");


		string profileText = File.ReadAllText(@".\lodestone\html\profile.html");
		ProfileHtml.LoadHtml(profileText);

		string invalidRaceClanGenderText = File.ReadAllText(@".\lodestone\html\invalid_race_clan_gender.html");
		InvalidRaceClanGenderHtml.LoadHtml(invalidRaceClanGenderText);
	}


	[TestMethod]
	public void ParseName_Test()
	{
		// act
		string name = ProfileParser.ParseName(ProfileHtml.DocumentNode);

		// assert
		name.Should().NotBeNullOrWhiteSpace()
			.And
			.BeEquivalentTo("Elseif Machina");
	}

	[TestMethod]
	public void ParseName_Null_Html_Test()
	{
		// act

		Action act = () => ProfileParser.ParseName(null!);

		// asert 
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseName_Invalid_Html_Test()
	{
		// arrange

		// act
		Action act = () => ProfileParser.ParseName(InvalidHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseRace_Invalid_Enum_Test()
	{
		// act
		Action act = () => ProfileParser.ParseRace(InvalidRaceClanGenderHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentOutOfRangeException>();
	}

	[TestMethod]
	public void ParseRace_Test()
	{
		// act
		Race race = ProfileParser.ParseRace(ProfileHtml.DocumentNode);

		// assert
		race.Should().Be(Race.Roegadyn, "Character in the html has this race");
	}

	[TestMethod]
	public void ParseRace_Null_Html_Test()
	{
		// act
		Action act = () => ProfileParser.ParseRace(null!);

		// assert
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseRace_Invalid_Html_Test()
	{
		// act
		Action act = () => ProfileParser.ParseRace(InvalidHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseClan_Test()
	{
		// assert
		Clan clan = ProfileParser.ParseClan(ProfileHtml.DocumentNode);

		// act
		clan.Should().Be(Clan.Hellsguard, "it is the characters clan in HTML");
	}

	[TestMethod]
	public void ParseClan_Null_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseClan(null!);

		// act
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseClan_Invalid_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseClan(InvalidHtml.DocumentNode);

		// act
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseClan_Invalid_Enum_Test()
	{
		// act
		Action act = () => ProfileParser.ParseClan(InvalidRaceClanGenderHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentOutOfRangeException>();
	}

	[TestMethod]
	public void ParseGender_Test()
	{
		// assert
		Gender gender = ProfileParser.ParseGender(ProfileHtml.DocumentNode);

		// act
		gender.Should().Be(Gender.Male, "it is the characters gender in HTML");
	}

	[TestMethod]
	public void ParseGender_Null_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseGender(null!);

		// act
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseGender_Invalid_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseClan(InvalidHtml.DocumentNode);

		// act
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseGender_Invalid_Enum_Test()
	{
		// act
		Action act = () => ProfileParser.ParseGender(InvalidRaceClanGenderHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentOutOfRangeException>();
	}

	[TestMethod]
	public void ParseNameDay_Test()
	{
		// assert
		string nameDay = ProfileParser.ParseNameDay(ProfileHtml.DocumentNode);

		// act
		nameDay.Should().BeEquivalentTo("13th Sun of the 3rd Astral Moon", "It's the name day character has in HTML");
	}

	[TestMethod]
	public void ParseNameDay_Null_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseNameDay(null!);

		// act
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseNameDay_Invalid_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseNameDay(InvalidHtml.DocumentNode);

		// act
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseCityState_Test()
	{
		// assert
		CityState cityState = ProfileParser.ParseCityState(ProfileHtml.DocumentNode);

		// act
		cityState.Should().Be(CityState.Gridania, "It's the city state character has in HTML");
	}

	[TestMethod]
	public void ParseCityState_Null_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseCityState(null!);

		// act
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseCityState_Invalid_Html_Test()
	{
		// assert
		Action act = () => ProfileParser.ParseCityState(InvalidHtml.DocumentNode);

		// act
		act.Should().Throw<ArgumentException>();
	}

	[TestMethod]
	public void ParseServer_Test()
	{
		// act
		string serverName = ProfileParser.ParseServer(ProfileHtml.DocumentNode);

		// assert
		serverName.Should().NotBeNullOrWhiteSpace().And.BeEquivalentTo("Twintania (Light)");
	}

	[TestMethod]
	public void ParseServer_Null_Test()
	{
		// act
		Action act = () => ProfileParser.ParseServer(null!);

		// assert
		act.Should().Throw<ArgumentNullException>();
	}

	[TestMethod]
	public void ParseServer_Invalid_Html_Test()
	{
		// act
		Action act = () => ProfileParser.ParseServer(InvalidHtml.DocumentNode);

		// assert
		act.Should().Throw<ArgumentException>();
	}



	[TestMethod]
	public void ParseGrandComapny_Test()
	{
		// act
		GrandCompanyInfo grandCompanyInfo = ProfileParser.ParseGrandComapny(ProfileHtml.DocumentNode);

		// assert
		grandCompanyInfo.Should().NotBeNull();

		grandCompanyInfo.GrandCompany.Should().Be(GrandCompany.ImmortalFlames);
		grandCompanyInfo.Rank.Should().Be(GrandCompanyRank.SecondFlameLieutenant);
	}


	[TestMethod]
	public void ParseProfile_Test()
	{
		// act
		Profile profile = ProfileParser.ParseProfile(ProfileHtml.DocumentNode);

		// assert
		profile.Should().NotBeNull();

		profile.CityState.Should().Be(CityState.Gridania);
		profile.Clan.Should().Be(Clan.Hellsguard);
		profile.Gender.Should().Be(Gender.Male);
		profile.Name.Should().Be("Elseif Machina");
		profile.NameDay.Should().Be("13th Sun of the 3rd Astral Moon");
		profile.Server.Should().Be("Twintania (Light)");
		profile.Race.Should().Be(Race.Roegadyn);
		profile.GrandCompanyInfo.Should().Be(new GrandCompanyInfo(GrandCompany.ImmortalFlames, GrandCompanyRank.SecondFlameLieutenant));

	}
}
