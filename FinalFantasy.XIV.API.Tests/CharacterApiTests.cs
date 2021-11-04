using System.Threading.Tasks;
using FinalFantasy.XIV.API.Services.Character;
using FinalFantasy.XIV.API.Services.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;

namespace FinalFantasy.XIV.API.Tests;

[TestClass]
public class CharacterApiTests
{
	private ICharacterApiRefit Client { get; }

	private string PrivateKey { get; }

	public CharacterApiTests()
	{
		var config = new ConfigHelper();
		PrivateKey = config.PrivateKey;
		Client = RestService.For<ICharacterApiRefit>(config.Host);
	}

    [TestMethod]
    public async Task CharacterApiTests_Search()
    {
		var response = await Client.SearchAsync(PrivateKey, "God", null,null);
		Assert.IsNotNull(response);
	}
}
