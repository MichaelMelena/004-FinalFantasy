using System.Threading.Tasks;
using FinalFantasy.XIV.API.Models.GameData.Servers;
using FinalFantasy.XIV.API.Services.Config;
using FinalFantasy.XIV.API.Services.Server;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;

namespace FinalFantasy.XIV.API.Tests;

[TestClass]
public class ServersApiTests
{
	private IServersApiRefit Client { get; set; }

	private string PrivateKey { get; set; }

	public ServersApiTests()
	{
		var config = new ConfigHelper();
		PrivateKey = config.PrivateKey;
		Client = RestService.For<IServersApiRefit>(config.Host, RefitSettingFactory.CreateSettings());
	}

	[TestMethod]
	public async Task ServersApiTests_GetAllServers()
	{
		ServersResponse response = await Client.ServersAsync(PrivateKey);

		response.Should().NotBeNull();
		response.Should().HaveCountGreaterThan(0);
		response.Should().Contain("Moogle");
	}

	[TestMethod]
	public async Task ServersApiTests_GetServersByDataCenter()
	{
		ServersByDataCenterResponse response = await Client.ServersByDataCenterAsync(PrivateKey);

		response.Should().NotBeNull();
		response.Aether.Should().HaveCountGreaterThan(0);
		response.Chaos.Should().HaveCountGreaterThan(0);
		response.Crystal.Should().HaveCountGreaterThan(0);
		response.Elemental.Should().HaveCountGreaterThan(0);
		response.Gaia.Should().HaveCountGreaterThan(0);
		response.Korea.Should().HaveCountGreaterThan(0);
		response.Light.Should().HaveCountGreaterThan(0);
		response.Mana.Should().HaveCountGreaterThan(0);
		response.Primal.Should().HaveCountGreaterThan(0);
		response.Carbuncle.Should().HaveCountGreaterThan(0);
		response.Moogle.Should().HaveCountGreaterThan(0);
		response.Chocobo.Should().HaveCountGreaterThan(0);
	}
}
