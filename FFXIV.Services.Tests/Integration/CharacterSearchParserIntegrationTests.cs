using FFXIV.Models.Search;
using FFXIV.Services.Lodestone.Http;
using FFXIV.Services.Parsers.CharacterSearch;
using HtmlAgilityPack;
using Refit;

namespace FFXIV.Services.Tests.Integration;

public class CharacterSearchParserIntegrationTests
{
	private string Name = "Elseif Machina";
	private static ILodestoneCharacterProfileApi? _api;
	ICharacterSearchParser parser = new CharacterSearchParser();


	[ClassInitialize]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
	public static void ClassInitialize(TestContext context)
	{
		_api = RestService.For<ILodestoneCharacterProfileApi>("https://eu.finalfantasyxiv.com");
	}

	[TestMethod]
	public async Task ParseCharacterSearchTest()
	{
		// setup


		// act

		ApiResponse<string> response = await _api!.Search(Name, null, null, null, null);

		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(response.Content);

		List<CharacterSearchProfile> profiles = parser.ParseSearchItems(htmlDocument.DocumentNode);

		// assert
		response.IsSuccessStatusCode.Should().BeTrue();

		response.Content.Should().NotBeNullOrEmpty();
		profiles.Should().NotBeNullOrEmpty();

		profiles.Should().Contain(profilePredicate => profilePredicate.Name == Name);
		CharacterSearchProfile profile = profiles.First(x => x.Name == Name);

		profile.Language.Should().Be(Language.EN);

		profile.Server.Should().NotBeNull();
		profile.Server.HomeWorld.Should().Be(HomeWorld.Twintania);
		profile.Server.DataCenter.Should().Be(DataCenter.Light);

		profile.CharacterUri.Should().Be(new Uri("/lodestone/character/28632101/"));
		profile.PortraitUri.Should().NotBeNull();

	}
}

