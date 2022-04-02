using FFXIV.Models.Characters.Profiles;
using FFXIV.Services.Lodestone.Http;
using Refit;

namespace FFXIV.Services.Tests.Lodestone;

[TestClass, TestCategory("Integration")]
public class CharacterSearchTests
{

	private readonly ILodestoneCharacterProfileApi _api;

	public CharacterSearchTests()
	{
		_api = RestService.For<ILodestoneCharacterProfileApi>("https://eu.finalfantasyxiv.com");

	}

	[TestMethod]
	public async Task SearchCharacterTest()
	{

		// setup

		string name = "Elseif Machina";

		// act

		ApiResponse<string> response = await _api.Search(name, null, null, null, null);

		// assert
		response.IsSuccessStatusCode.Should().BeTrue();

		response.Content.Should().NotBeNullOrEmpty();

	}

	[TestMethod]
	public async Task GetCharacterTest()
	{
		string id = "28632101";
		ApiResponse<string> response = await _api.GetCharacterAsync(id);
		response.Content.Should().NotBeNullOrWhiteSpace();
	}

	

}
