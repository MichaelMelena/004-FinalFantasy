using FFXIV.Facades.Search;
using FFXIV.Models.Search;
using FFXIV.Services.Lodestone.Http;
using FFXIV.Services.Parsers.CharacterSearch;
using HtmlAgilityPack;
using Refit;

namespace FFXIV.Services.Tests.Integration;

public class CharacterSearchParserIntegrationTests
{
	private string Name = "Elseif Machina";
	private static ILodestoneCharacterProfileApi? api;
	private static ICharacterSearchParser parser = new CharacterSearchParser();
	private static ICharacterSearchFacade? characterSearchFacade;


	[ClassInitialize]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
	public static void ClassInitialize(TestContext context)
	{
		
		api = RestService.For<ILodestoneCharacterProfileApi>("https://eu.finalfantasyxiv.com");
		characterSearchFacade = new CharacterSearchFacade(api, parser);
	}

	[TestMethod]
	public async Task ParseCharacterSearchTest()
	{
		// setup
		ProfileSearchRequest profileSearchRequest = new ProfileSearchRequest
		{
			Name = Name
		};

		// act
		List<CharacterSearchProfile> profiles = await characterSearchFacade!.GetSearchProfilesAsync(profileSearchRequest);

		// assert
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

